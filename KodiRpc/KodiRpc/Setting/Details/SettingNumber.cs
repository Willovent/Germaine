using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Setting.Details
{
   public class SettingNumber : KodiRpc.Setting.Details.SettingBase
   {
       [Newtonsoft.Json.JsonProperty("default")]
       public double Default { get; set; }
       public double maximum { get; set; }
       public double minimum { get; set; }
       public double step { get; set; }
       public double value { get; set; }
    }
}
