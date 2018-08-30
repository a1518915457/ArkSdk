using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkSdk.Util
{
    class ArkUtils
    {
        public static string SignArkRequest(string url, IDictionary<string, string> reqParams, IDictionary<string, string> sysParams, string appSecret)
        {
            // 1.对除sign外的系统参数和所有请求参数进行排序，Request Body（data）不参与排序。
            IDictionary<string, string> sortedParams = new SortedDictionary<string, string>(reqParams, StringComparer.Ordinal);
            foreach (KeyValuePair<string, string> kv in sysParams)
            {
                if (kv.Key != "sign")
                {
                    sortedParams.Add(kv.Key, kv.Value);
                }
            }

            // 2.使用QueryString的格式（即key1=value1&key2=value2…）拼接字符串和URL（不包含host部分）
            // 3.连接app-secret的值在最末尾，至此为签名原始字符串
            List<string> queries = new List<string>();
            foreach (KeyValuePair<string, string> p in sortedParams)
            {
                if (!string.IsNullOrEmpty(p.Key) && !string.IsNullOrEmpty(p.Value))
                {
                    queries.Add(p.Key + "=" + p.Value);
                }
            }
            string queryString = string.Join("&", queries);
            string s = url + "?" + queryString + appSecret;

            // 4.MD5计算签名
            return Hash.Md5(s);
        }
    }
}
