using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Azure.Identity;

namespace B2CPolicyManager
{
    public abstract class AuthenticationHelperBase
    {
		protected virtual String[] DefaultScopes
			{ get; } =[ "User.Read" ];

		protected String TenantId { get; }

		protected virtual String Authority
			=> $"{AzureAuthorityHosts.AzurePublicCloud}{TenantId}/";

		protected AuthenticationHelperBase(
			String TenantId
		)
		{
			this.TenantId = TenantId;
		}

		public async Task AddHeadersAsync( 
			HttpRequestMessage requestMessage, 
			String[] Scopes = default, 
			CancellationToken cancellation = default
		)
		{
			string token = await GetTokenAsync( Scopes, cancellation );
			try
			{
				requestMessage.Headers.Authorization = new AuthenticationHeaderValue( "bearer", token );
			}
			catch( Exception ex )
			{
				Debug.WriteLine( "Could not add headers to HttpRequestMessage: " + ex.Message );
			}
		}

		public abstract Task<String> GetTokenAsync(
			String[] Scopes = default,
			CancellationToken cancellation = default
		);
	}
}
