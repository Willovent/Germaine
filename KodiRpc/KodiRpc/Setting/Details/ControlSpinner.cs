using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Setting.Details
{
   public class ControlSpinner : KodiRpc.Setting.Details.ControlBase
   {
       public string formatlabel { get; set; }
       public string minimumlabel { get; set; }
       public KodiRpc.Setting.Details.ControlSpinner_type type { get; set; }
    }
}
