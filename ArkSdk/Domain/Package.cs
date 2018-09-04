using ArkSdk.JsonConverters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkSdk.Domain
{
    public class Package : ArkObject
    {
        [JsonProperty("package_id")]
        public string PackageId { get; set; }

        [JsonProperty("logistics")]
        public string Logistics { get; set; }

        [JsonProperty("time")]
        [JsonConverter(typeof(MyUnixDateTimeConverter))]
        public DateTime Time { get; set; }

        [JsonProperty("pay_time")]
        [JsonConverter(typeof(MyUnixDateTimeConverter))]
        public DateTime PayTime { get; set; }

        [JsonProperty("confirm_time")]
        [JsonConverter(typeof(MyUnixDateTimeConverter))]
        public DateTime ConfirmTime { get; set; }

        [JsonProperty("express_company_code")]
        public string ExpressCompanyCode { get; set; }

        [JsonProperty("express_company_name")]
        public string ExpressCompanyName { get; set; }

        [JsonProperty("express_no")]
        public string ExpressNo { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("receiver_name")]
        public string ReceiverName { get; set; }

        [JsonProperty("receiver_phone")]
        public string ReceiverPhone { get; set; }

        [JsonProperty("receiver_address")]
        public string ReceiverAddress { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("total_net_weight")]
        public decimal TotalNetWeight { get; set; }

        [JsonProperty("pay_amount")]
        public string PayAmount { get; set; }

        [JsonProperty("id_number")]
        public string IdNumber { get; set; }

        [JsonProperty("international_express_no")]
        public string InternationalExpressNo { get; set; }

        [JsonProperty("delivery_time_preference")]
        public string DeliveryTimePreference { get; set; }

        [JsonProperty("order_declared_amount")]
        public string OrderDeclaredAmount { get; set; }

        [JsonProperty("paint_marker")]
        public string PaintMarker { get; set; }

        [JsonProperty("express_extend_1")]
        public string ExpressExtend1 { get; set; }

        [JsonProperty("express_extend_2")]
        public string ExpressExtend2 { get; set; }

        [JsonProperty("item_number")]
        public int ItemNumber { get; set; }

        [JsonProperty("item_list")]
        public List<Item> ItemList { get; set; }
    }
}
