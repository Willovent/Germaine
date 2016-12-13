using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Setting.Details
{
   public class SettingList : KodiRpc.Setting.Details.SettingBase
   {
       [Newtonsoft.Json.JsonProperty("default")]
       public global::System.Collections.Generic.List<object> Default { get; set; }
       public object definition { get; set; }
       public string delimiter { get; set; }
       public KodiRpc.Setting.Type elementtype { get; set; }
       public int maximumitems { get; set; }
       public int minimumitems { get; set; }
       public global::System.Collections.Generic.List<object> value { get; set; }
    }
}
