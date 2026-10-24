using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Azure.Identity;

using B2CPolicyManager.Models;
using Microsoft.Identity.Client;
using Microsoft.Identity.Web;

using Newtonsoft.Json.Linq;

namespace B2CPolicyManager
{
	public class ConfidentialAuthenticationHelper
		: AuthenticationHelperBase
	{
		protected override String[] DefaultScopes
			{ get; } = [ "https://graph.microsoft.com/.default" ];

		private IConfidentialClientApplication _confidentialApp { get; }

		public String Token { get; private set; }

		public ConfidentialAuthenticationHelper( 
			string TenantId,
			Guid AppId,
			string AppSecret
		)
			: base( TenantId )
		{
			_confidentialApp = ConfidentialClientApplicationBuilder.Create( AppId.ToString( "D" ) )
				.WithAuthority( Authority )
				.WithClientSecret( AppSecret )
				.Build();
			_confidentialApp.AddInMemoryTokenCache();
		}

		public override async Task<string> GetTokenAsync(
			String[] Scopes = default,
			CancellationToken cancellation = default
		)
		{
			Scopes ??= DefaultScopes;

			var authResult = await _confidentialApp
				.AcquireTokenForClient( Scopes )
				.ExecuteAsync( cancellation )
			;

			return authResult.AccessToken;
		}
	}
}
