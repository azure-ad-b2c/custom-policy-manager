using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Identity.Client;

namespace B2CPolicyManager
{
	public class PublicAuthenticationHelper
		: AuthenticationHelperBase
	{
		static readonly string[] DefaultScope = ["User.Read"];

		private IPublicClientApplication _publicApp { get; }

		public PublicAuthenticationHelper( 
			string TenantId,
			Guid AppId
		)
			:base( TenantId )
		{
			_publicApp = PublicClientApplicationBuilder.Create( AppId.ToString( "D" ) )
				.WithAuthority( Authority )
				// .WithDefaultRedirectUri()
				.WithRedirectUri( "http://localhost" )
				.Build();

			// The persistent token cache uses DPAPI, which has no cross-platform
			// implementation; elsewhere MSAL's in-memory cache still avoids
			// repeated prompts within a single process
			if( OperatingSystem.IsWindows() )
			{
				TokenCacheHelper.EnableSerialization( _publicApp.UserTokenCache );
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>Token for user.</returns>
		public async Task ClearCacheAsync()
		{
			var accounts = (await _publicApp.GetAccountsAsync()).ToList();
			foreach( var account in accounts )
			{
				await _publicApp.RemoveAsync( account );
			}
		}

		public override async Task<string> GetTokenAsync( 
			String[] Scopes = default, 
			CancellationToken cancellation = default
		)
		{
			string token = null;

			Scopes ??= PublicAuthenticationHelper.DefaultScope;

			var accounts = (await _publicApp.GetAccountsAsync()).ToList();

			try
			{
				var authResult = await _publicApp.AcquireTokenSilent( Scopes, accounts.FirstOrDefault() )
					.ExecuteAsync( cancellation )
					.ConfigureAwait( false );

				token = authResult.AccessToken;
			}

			catch( MsalUiRequiredException )
			{
				try
				{
					var authResult = await _publicApp.AcquireTokenInteractive( Scopes )
						.WithAccount( accounts.FirstOrDefault() )
						.WithPrompt( Prompt.NoPrompt )
						.ExecuteAsync( cancellation )
						.ConfigureAwait( false );

					token = authResult.AccessToken;
				}
				catch
				{
					return token;
				}
				//}
			}

			return token;
		}

		//public async Task<String> GetTokenForAppAsync(
		//	String[] Scopes = default,
		//	CancellationToken cancellation = default
		//)
		//{
		//	String token;

		//	try
		//	{
		//		var authResult = await _publicApp.AcquireTokenSilent( DefaultScope, accounts.FirstOrDefault() )
		//			.ExecuteAsync( cancellation )
		//			.ConfigureAwait( false );

		//		token = authResult.AccessToken;
		//	}



		//	return token;
		//}

	}
}