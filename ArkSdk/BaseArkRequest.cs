using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkSdk
{
    public abstract class BaseArkRequest<T> : IArkRequest<T> where T : ArkResponse
    {
        public virtual string GetBody()
        {
            return "";
        }

        public virtual string GetMethod()
        {
            return "GET";
        }

        public virtual IDictionary<string, string> GetParameters()
        {
            return new ArkDictionary();
        }

        public abstract string GetUrl();

        public abstract void Validate();
    }
}
