﻿using ArkSdk.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkSdk.Response
{
    public class PackageGetResponse : ArkResponse
    {
        [JsonProperty("data")]
        public Package Package { get; set; }
    }
}
