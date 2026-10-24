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

        // leave these as-is - Private Preview Graph URIs for custom trust framework policy
        public const string TrustFrameworkPoliciesUri = "https://graph.microsoft.com/beta/trustframework/policies";
        public const string TrustFrameworkPolicyByIDUri = "https://graph.microsoft.com/beta/trustframework/policies/{0}";
        public const string TrustFrameworkPolicyByIDUriPUT = "https://graph.microsoft.com/beta/trustframework/policies/{0}/$value";
        // public const string TrustFrameworkPolicyContentsByTenantAndIDUri = "https://main.b2cadmin.ext.azure.com/api/trustframework/GetCustomPolicyAsXml?sendAsAttachment=false&tenantId={0}&policyId={1}&getBasePolicies=false";
	}
}
