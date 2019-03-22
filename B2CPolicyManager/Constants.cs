using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2CPolicyManager
{
    class Constants
    {
        // TODO: update "ClientIdForUserAuthn" with your app guid and "Tenant" with your tenant name
        //       see README.md for instructions

        // Client ID is the application guid used uniquely identify itself to the v2.0 authentication endpoint
        //public const string ClientIdForUserAuthn = "ca203d7f-2bc5-4880-be3e-097a1d738ed3";
        // Your tenant Name, for example "myb2ctenant.onmicrosoft.com"
        //public const string Tenant = "b2cprod.onmicrosoft.com";

        // leave these as-is - URIs used for auth
        public string AuthorityUri = "https://login.microsoftonline.com/" + Properties.Settings.Default.TenantId + "/oauth2/v2.0/token";
        public const string RedirectUriForAppAuthn = "https://login.microsoftonline.com";

        // leave these as-is - Private Preview Graph URIs for custom trust framework policy
        public const string TrustFrameworkPolicesUri = "https://graph.microsoft.com/testcpimtf/trustFrameworkPolicies";
        public const string TrustFrameworkPolicyByIDUri = "https://graph.microsoft.com/testcpimtf/trustFrameworkPolicies/{0}";
        public const string TrustFrameworkPolicyByIDUriPUT = "https://graph.microsoft.com/testcpimtf/trustFrameworkPolicies/{0}/$value";
    }
}
