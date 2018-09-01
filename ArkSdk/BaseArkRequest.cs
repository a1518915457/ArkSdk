using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkSdk
{
    public abstract class BaseArkRequest<T> : IArkRequest<T> where T : ArkResponse
    {
        public abstract string GetMethod();
        public abstract IDictionary<string, string> GetParameters();
        public abstract string GetUrl();
    }
}
