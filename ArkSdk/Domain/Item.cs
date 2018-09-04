using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkSdk.Domain
{
    public class Item : ArkObject
    {
        [JsonProperty("merchant_discount")]
        public string MerchantDiscount { get; set; }

        [JsonProperty("red_discount")]
        public string RedDiscount { get; set; }

        [JsonProperty("barcode")]
        public string BarCode { get; set; }

        [JsonProperty("skucode")]
        public string SkuCode { get; set; }

        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        [JsonProperty("specification")]
        public string Specification { get; set; }

        [JsonProperty("qty")]
        public int Qty { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("pay_price")]
        public string PayPrice { get; set; }

        [JsonProperty("net_weight")]
        public decimal NetWeight { get; set; }

        [JsonProperty("register_name")]
        public string RegisterName { get; set; }
    }
}
