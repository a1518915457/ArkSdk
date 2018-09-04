using Newtonsoft.Json;
using System;
using System.Xml.Serialization;

namespace ArkSdk
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class ArkResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        [JsonProperty("error_msg")]
        public string ErrorMsg { get; set; }

        public string Body { get; set; }
    }
}
