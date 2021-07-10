using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2CPolicyManager
{
    class AppList
    {

        [JsonProperty("@odata.context")]
        public string OdataContext { get; set; }
        public List<App> value { get; set; }
    }
    public class Spa
    {
        public List<string> redirectUris { get; set; }
    }
    public class Web
    {
        public List<string> redirectUris { get; set; }

    }

    public class App
    {
        [JsonProperty("@odata.id")]
        public string OdataId { get; set; }
        public string id { get; set; }
        public object deletedDateTime { get; set; }
        public string appId { get; set; }
        public object applicationTemplateId { get; set; }
        public List<string> identifierUris { get; set; }
        public DateTime createdDateTime { get; set; }
        public object description { get; set; }
        public object disabledByMicrosoftStatus { get; set; }
        public string displayName { get; set; }
        public bool isAuthorizationServiceEnabled { get; set; }
        public object isDeviceOnlyAuthSupported { get; set; }
        public bool? isFallbackPublicClient { get; set; }
        public object isManagementRestricted { get; set; }
        public object groupMembershipClaims { get; set; }
        public object notes { get; set; }
        public bool oauth2RequirePostResponse { get; set; }
        public List<object> orgRestrictions { get; set; }
        public string publisherDomain { get; set; }
        public string signInAudience { get; set; }
        public List<string> tags { get; set; }
        public object tokenEncryptionKeyId { get; set; }
        public object uniqueName { get; set; }
        public object defaultRedirectUri { get; set; }
        public List<object> addIns { get; set; }
        public List<object> appCapabilities { get; set; }
        public object optionalClaims { get; set; }
        public Spa spa { get; set; }
        public Web web { get; set; }

    }
}
