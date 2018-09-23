using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkSdk.Request
{
    public class PackagesGetRequest : BaseArkRequest<Response.PackagesGetResponse>
    {
        public Nullable<DateTime> StartTime { get; set; }

        public Nullable<DateTime> EndTime { get; set; }

        public string Status { get; set; }

        public Nullable<int> PageNo { get; set; }

        public Nullable<int> PageSize { get; set; }

        public string Logistics { get; set; }

        public override string GetMethod()
        {
            return "GET";
        }

        public override IDictionary<string, string> GetParameters()
        {
            ArkDictionary parameters = new ArkDictionary();
            parameters.Add("start_time", this.StartTime);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("status", this.Status);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("logistics", this.Logistics);
            return parameters;
        }

        public override string GetUrl()
        {
            return "/ark/open_api/v0/packages";
        }

        public override void Validate()
        {
        }
    }
}
