using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2CPolicyManager
{
    public class InnerError
    {
        public string correlationId { get; set; }
        public DateTime date { get; set; }

        [JsonProperty("request-id")]
        public string RequestId { get; set; }

        [JsonProperty("client-request-id")]
        public string ClientRequestId { get; set; }
    }

    public class Error
    {
        public string code { get; set; }
        public string message { get; set; }
        public InnerError innerError { get; set; }
    }
    class uploadPolicyResponseError
    {
        public Error error { get; set; }
    }
}
