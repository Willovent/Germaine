using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Setting.Details
{
   public class SettingString : KodiRpc.Setting.Details.SettingBase
   {
       public bool allowempty { get; set; }
       [Newtonsoft.Json.JsonProperty("default")]
       public string Default { get; set; }
       public global::System.Collections.Generic.List<KodiRpc.Setting.Details.SettingString_optionsItem> options { get; set; }
       public string value { get; set; }
    }
}
