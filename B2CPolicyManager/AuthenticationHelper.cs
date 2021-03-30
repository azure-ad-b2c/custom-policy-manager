using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace B2CPolicyManager
{
    public class AuthenticationHelper
    {
        public static string[] Scopes = { "User.Read" };

        public static string authority = "https://login.microsoftonline.com/{0}/v2.0";

        //public AuthenticationContext;

        private static readonly object padlock = new object();



       // public static DateTimeOffset Expiration;



        static IPublicClientApplication _app;

        /// <summary>
        /// Get Token for User.
        /// </summary>
        /// <returns>Token for user.</returns>
        public static async void ClearCache()
        {
            var accounts = (await _app.GetAccountsAsync()).ToList();
            while (accounts.Any())
            {
                await _app.RemoveAsync(accounts.First());
                accounts = (await _app.GetAccountsAsync()).ToList();
            }
        }
        public static async Task<string> GetTokenForUserAsync()
        {
            //AuthenticationContext ADALIdentityClientApp = new AuthenticationContext(authority +
            //    Properties.Settings.Default.TenantId);
            AuthenticationResult authResult;

            authority = string.Format(CultureInfo.InvariantCulture, authority, Properties.Settings.Default.TenantId);
            if (_app == null)
            {
                _app = PublicClientApplicationBuilder.Create(Properties.Settings.Default.V2AppId)
                  .WithAuthority(authority)
                  .WithRedirectUri("https://b2capi.com")
                  .Build();
                TokenCacheHelper.EnableSerialization(_app.UserTokenCache);
            }

            var accounts = (await _app.GetAccountsAsync()).ToList();
            string tokenForUser = null;
            try
            {
                authResult = await _app.AcquireTokenSilent(Scopes, accounts.FirstOrDefault())
                    .ExecuteAsync()
                    .ConfigureAwait(false);

                //authResult = await ADALIdentityClientApp.AcquireTokenAsync("https://graph.microsoft.com", Properties.Settings.Default.V2AppId, new Uri("https://b2capi.com"), new PlatformParameters(PromptBehavior.Auto));

                //authResult = await ADALIdentityClientApp.AcquireTokenSilentAsync(Scopes, ADALIdentityClientApp.Users.First());
                tokenForUser = authResult.AccessToken;
            }

            catch (MsalUiRequiredException)
            {
                //if (tokenForUser == null || Expiration <= DateTimeOffset.UtcNow.AddMinutes(5))
                //{
                    try
                    {
                        //authResult = await ADALIdentityClientApp.AcquireTokenAsync("https://graph.microsoft.com", Properties.Settings.Default.V2AppId, new Uri("https://b2capi.com"), new PlatformParameters(PromptBehavior.Auto));

                        authResult = await _app.AcquireTokenInteractive(Scopes)
                        .WithAccount(accounts.FirstOrDefault())
                        .WithPrompt(Prompt.SelectAccount)
                        .ExecuteAsync()
                        .ConfigureAwait(false);
                        tokenForUser = authResult.AccessToken;
                        //Expiration = authResult.ExpiresOn;
                    }
                    catch
                    {
                        return tokenForUser;
                    }
                //}
            }

            return tokenForUser;
        }


        public static async Task AddHeadersAsync(HttpRequestMessage requestMessage)
        {
            string tokenForUser = await GetTokenForUserAsync();
            try
            {
                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", tokenForUser);
                requestMessage.Headers.Add("SampleID", "policy-manager-jasuri");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Could not add headers to HttpRequestMessage: " + ex.Message);
            }
        }

    }
}