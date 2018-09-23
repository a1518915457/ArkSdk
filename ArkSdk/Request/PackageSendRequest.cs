using ArkSdk.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkSdk.Request
{
    [JsonObject(MemberSerialization.OptIn)]
    public class PackageSendRequest : BaseArkRequest<Response.PackageSendResponse>
    {
        public string PackageId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("express_company_code")]
        public string ExpressCompanyCode { get; set; }

        [JsonProperty("express_no")]
        public string ExpressNo { get; set; }

        public override string GetBody()
        {
            return JsonConvert.SerializeObject(this);
        }

        public override string GetMethod()
        {
            return "PUT";
        }

        public override string GetUrl()
        {
            return "/ark/open_api/v0/packages/" + PackageId;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("package_id", this.PackageId);
            RequestValidator.ValidateRequired("status", this.Status);
            RequestValidator.ValidateRequired("express_company_code", this.ExpressCompanyCode);
            RequestValidator.ValidateRequired("express_no", this.ExpressNo);
        }
    }
}
