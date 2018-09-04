using ArkSdk.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ArkSdk
{
    public class DefaultArkClient : IArkClient
    {
        internal string serverUrl;
        internal string appKey;
        internal string appSecret;

        public DefaultArkClient(string serverUrl, string appKey, string appSecret)
        {
            this.serverUrl = serverUrl;
            this.appKey = appKey;
            this.appSecret = appSecret;
        }

        public virtual T Execute<T>(IArkRequest<T> request) where T : ArkResponse
        {
            return DoExecute<T>(request, DateTime.Now);
        }

        public virtual T Execute<T>(IArkRequest<T> request, DateTime timestamp) where T : ArkResponse
        {
            return DoExecute<T>(request, timestamp);
        }

        private T DoExecute<T>(IArkRequest<T> request, DateTime timestamp) where T : ArkResponse
        {
            string url = request.GetUrl();
            ArkDictionary reqParams = new ArkDictionary(request.GetParameters());
            ArkDictionary sysParams = new ArkDictionary();
            sysParams.Add("timestamp", timestamp);
            sysParams.Add("app-key", appKey);
            sysParams.Add("sign", ArkUtils.SignArkRequest(url, reqParams, sysParams, appSecret));

            string realServerUrl = serverUrl + url;
            string body = GetResponse(realServerUrl, request.GetMethod(), reqParams, sysParams, request.GetBody());
            T rsp = JsonConvert.DeserializeObject<T>(body);
            rsp.Body = body;
            return rsp;
        }

        private string GetResponse(string url, string method, IDictionary<string, string> reqParams, IDictionary<string, string> sysParams, string body)
        {
            List<string> queries = new List<string>();
            foreach (KeyValuePair<string, string> p in reqParams)
            {
                if (!string.IsNullOrEmpty(p.Key) && !string.IsNullOrEmpty(p.Value))
                {
                    queries.Add(p.Key + "=" + p.Value);
                }
            }
            string queryString = string.Join("&", queries);
            string reqUrl = url + "?" + queryString;

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(reqUrl);
            req.Method = method;
            req.ContentType = "application/json;charset=utf-8";

            foreach (KeyValuePair<string, string> p in sysParams)
            {
                if (!string.IsNullOrEmpty(p.Key) && !string.IsNullOrEmpty(p.Value))
                {
                    req.Headers[p.Key] = p.Value;
                }
            }

            if (!string.IsNullOrEmpty(body) && (method == "POST" || method == "PUT" || method == "PATCH"))
            {
                byte[] bytes = Encoding.UTF8.GetBytes(body);
                req.ContentLength = bytes.Length;
                using (Stream stream = req.GetRequestStream())
                {
                    stream.Write(bytes, 0, bytes.Length);
                }
            }

            HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
            using (Stream stream = rsp.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                return reader.ReadToEnd();
            }
        }
    }
}
