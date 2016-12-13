using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Setting.Details
{
   public class SettingInt : KodiRpc.Setting.Details.SettingBase
   {
       [Newtonsoft.Json.JsonProperty("default")]
       public int Default { get; set; }
       public int maximum { get; set; }
       public int minimum { get; set; }
       public global::System.Collections.Generic.List<KodiRpc.Setting.Details.SettingInt_optionsItem> options { get; set; }
       public int step { get; set; }
       public int value { get; set; }
    }
}