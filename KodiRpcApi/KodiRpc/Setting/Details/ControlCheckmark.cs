using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Setting.Details
{
   public class ControlCheckmark : KodiRpc.Setting.Details.ControlBase
   {
       public KodiRpc.Setting.Details.ControlCheckmark_format format { get; set; }
       public KodiRpc.Setting.Details.ControlCheckmark_type type { get; set; }
    }
}
