using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

using Azure;

using B2CPolicyManager.Models;

using Microsoft.Extensions.Logging;

using Newtonsoft.Json;

namespace B2CPolicyManager
{
	public class PolicyManager
	{
		public AuthenticationHelperBase AuthenticationHelper { get; }

		public PolicyManager( AuthenticationHelperBase AuthenticationHelper )
		{
			this.AuthenticationHelper = AuthenticationHelper;
		}

		HttpHelper HttpHelper
			=> new( AuthenticationHelper );

		public async Task DeployPoliciesAsync( ILogger Logger, IEnumerable<String> PolicyFileNames, CancellationToken cancellation = default )
		{
			HttpResponseMessage response;

			Logger.LogInformation( "Deploying B2C resources..." );

			string token = await AuthenticationHelper.GetTokenAsync( cancellation: cancellation);
			if( token != null )
			{
				// Sort the policies by dependency so we write them in the correct order
				var unorderedPolicies = new List<Policy>();
				var orderedPolicies = new List<Policy>();

				foreach( string fileName in PolicyFileNames )
				{
					string xml = File.ReadAllText(fileName);

					unorderedPolicies.Add(
						new Policy( xml )
					);
				}

				while( unorderedPolicies.Count != 0 )
				{
					foreach( var policy in unorderedPolicies.ToArray().Where( p => !unorderedPolicies.Exists( pBase => pBase.Id.Equals( p.Base, StringComparison.OrdinalIgnoreCase ) ) ) )
					{
						orderedPolicies.Add( policy );
						unorderedPolicies.Remove( policy );
					}
				}

				// do the upload
				foreach( var policy in orderedPolicies )
				{
					response = await HttpHelper.HttpPutIDAsync( Constants.TrustFrameworkPolicyByIDUriPUT, policy.Id.ToUpperInvariant(), policy.Text, cancellation );
					if( response.IsSuccessStatusCode )
					{
						Logger.LogInformation( "Successfully updated policy {0}", policy.Id );
					}
					else
					{
						string content = await response.Content.ReadAsStringAsync();
						uploadPolicyResponseError errorMsg = JsonConvert.DeserializeObject<uploadPolicyResponseError>(content);
						Logger.LogError( "{0}; CorrelationId: {1}", errorMsg.error.message, errorMsg.error.innerError.correlationId );
					}
				}
			}

			Logger.LogInformation( "B2C resources deployed." );
		}

		public async Task<List<String>> GetPoliciesAsync( ILogger Logger, CancellationToken cancellation = default )
		{
			List<String> result;

			var response = await HttpHelper.HttpGetAsync( Constants.TrustFrameworkPoliciesUri, cancellation );
			string content = await response.Content.ReadAsStringAsync();

			if( response.IsSuccessStatusCode )
			{
				result = JsonConvert.DeserializeObject<PolicyList>( content )
					.Value
					.Select( v => v.Id )
					.ToList()
				;

				Logger.LogInformation( "Successfully fetched policy list." );
			}
			else
			{
				result = new();
				Logger.LogError( "Failed to fetch policy list. {0}", content );
			}

			return result;
		}

		public async IAsyncEnumerable<Policy> GetPolicyDefinitionsAsync( 
			ILogger Logger, 
			IEnumerable<String> PolicyNames, 
			[EnumeratorCancellation]
			CancellationToken cancellation = default )
		{
			foreach( var policyName in PolicyNames )
			{
				if( cancellation.IsCancellationRequested )
				{
					yield break;
				}

				// The get-by-id endpoint is case-sensitive; the tenant stores policy ids in uppercase
				var response = await HttpHelper.HttpGetIDAsync( Constants.TrustFrameworkPolicyByIDUriPUT, policyName.ToUpperInvariant(), cancellation );
				string content = await response.Content.ReadAsStringAsync();

				if( response.IsSuccessStatusCode )
				{
					Logger.LogDebug( "Successfully got policy definition {Policy}", policyName );
					yield return  new Policy( content );
				}
				else
				{
					Logger.LogError( "Failed to get policy definition {Policy}: {Status} {Error}", policyName, response.StatusCode, content );
				}
			}
		}

		public async Task<List<App>> GetAppRegistrationsAsync( ILogger Logger, CancellationToken cancellation = default )
		{
			List<App> result;
			HttpResponseMessage response;
			Logger.LogInformation( "Getting AAD B2C app registrations." );

			response = await HttpHelper.HttpGetAsync( "https://graph.microsoft.com/beta/applications", cancellation );
			string content = await response.Content.ReadAsStringAsync();

			if( response.IsSuccessStatusCode )
			{
				result = JsonConvert.DeserializeObject<AppList>( content ).value
					.Where( app => app.signInAudience == "AzureADandPersonalMicrosoftAccount" )
					.OrderBy( app => app.displayName )
					.ToList()
				;
			}
			else
			{
				result = [];
				Logger.LogError( "Failed to fetch app registrations." );
			}

			return result;
		}

		public async Task DeletePolicyAsync( ILogger Logger, String PolicyName, CancellationToken cancellation = default )
		{
			HttpResponseMessage response;

			Logger.LogInformation( "Deleting policy {0}", PolicyName );
			response = await HttpHelper.HttpDeleteIDAsync( Constants.TrustFrameworkPolicyByIDUri, PolicyName.ToUpperInvariant(), cancellation );

			if( response.IsSuccessStatusCode )
			{
				Logger.LogInformation( "Successfully deleted policy {Policy}", PolicyName );
			}
			else
			{
				string content = await response.Content.ReadAsStringAsync();
				Logger.LogInformation( "Failed to delete policy {Policy}: {Error}", PolicyName, content );
			}
		}

	}
}
