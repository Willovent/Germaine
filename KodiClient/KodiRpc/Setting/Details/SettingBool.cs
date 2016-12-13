using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Setting.Details
{
   public class SettingBool : KodiRpc.Setting.Details.SettingBase
   {
       [Newtonsoft.Json.JsonProperty("default")]
       public bool Default { get; set; }
       public bool value { get; set; }
    }
}
