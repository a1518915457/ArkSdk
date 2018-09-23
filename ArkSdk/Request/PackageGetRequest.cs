using ArkSdk.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkSdk.Request
{
    public class PackageGetRequest : BaseArkRequest<Response.PackageGetResponse>
    {
        public string PackageId { get; set; }

        public override string GetMethod()
        {
            return "GET";
        }

        public override IDictionary<string, string> GetParameters()
        {
            ArkDictionary parameters = new ArkDictionary();
            return parameters;
        }

        public override string GetUrl()
        {
            return "/ark/open_api/v0/packages/" + PackageId;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("package_id", this.PackageId);
        }
    }
}
