using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Setting.Details
{
   public class SettingBase : KodiRpc.Setting.Details.Base
   {
       public object control { get; set; }
       public bool enabled { get; set; }
       public KodiRpc.Setting.Level level { get; set; }
       public string parent { get; set; }
       public KodiRpc.Setting.Type type { get; set; }
    }
}
