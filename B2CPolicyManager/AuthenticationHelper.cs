using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace B2CPolicyManager
{
    public class AuthenticationHelper
    {
        public static string[] Scopes = { "User.Read" };

        public static string authority = "https://login.microsoftonline.com/";

        //public AuthenticationContext;

        private static readonly object padlock = new object();



        public static DateTimeOffset Expiration;

        /// <summary>
        /// Get Token for User.
        /// </summary>
        /// <returns>Token for user.</returns>
        public static async Task<string> GetTokenForUserAsync()
        {
            AuthenticationContext ADALIdentityClientApp = new AuthenticationContext(authority + Properties.Settings.Default.TenantId);
            AuthenticationResult authResult;
            string tokenForUser = null;
            try
            {

                authResult = await ADALIdentityClientApp.AcquireTokenAsync("https://graph.microsoft.com", Properties.Settings.Default.V2AppId, new Uri("https://b2capi.com"), new PlatformParameters(PromptBehavior.Auto));

                //authResult = await ADALIdentityClientApp.AcquireTokenSilentAsync(Scopes, ADALIdentityClientApp.Users.First());
                tokenForUser = authResult.AccessToken;
            }

            catch (Exception)
            {
                if (tokenForUser == null || Expiration <= DateTimeOffset.UtcNow.AddMinutes(5))
                {
                    try
                    {
                        authResult = await ADALIdentityClientApp.AcquireTokenAsync("https://graph.microsoft.com", Properties.Settings.Default.V2AppId, new Uri("https://b2capi.com"), new PlatformParameters(PromptBehavior.Auto));

                        tokenForUser = authResult.AccessToken;
                        Expiration = authResult.ExpiresOn;
                    }
                    catch
                    {
                        return tokenForUser;
                    }
                }
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