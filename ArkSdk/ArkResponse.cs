using System;
using System.Xml.Serialization;

namespace ArkSdk
{
    [Serializable]
    public abstract class ArkResponse
    {
        [XmlElement("success")]
        public bool Success { get; set; }

        [XmlElement("data")]
        public string Data { get; set; }

        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        public string Body { get; set; }
    }
}
