using ArkSdk.Domain;
using ArkSdk.JsonConverters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkSdk.Response
{
    [JsonConverter(typeof(JsonPathConverter))]
    public class PackagesGetResponse : ArkResponse
    {
        [JsonProperty("data.current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("data.total_page")]
        public int TotalPage { get; set; }

        [JsonProperty("data.page_size")]
        public int PageSize { get; set; }

        [JsonProperty("data.total_number")]
        public int TotalNumber { get; set; }

        [JsonProperty("data.package_list")]
        public List<Package> PackageList { get; set; }
    }
}
