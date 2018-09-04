using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkSdk
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class ArkObject
    {
    }
}
