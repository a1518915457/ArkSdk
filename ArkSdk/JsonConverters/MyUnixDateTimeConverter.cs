using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkSdk.JsonConverters
{
    public class MyUnixDateTimeConverter : UnixDateTimeConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            object result = base.ReadJson(reader, objectType, existingValue, serializer);
            if (result is DateTime)
            {
                // 强制转换为本地时间
                result = ((DateTime)result).ToLocalTime();
            }
            return result;
        }
    }
}
