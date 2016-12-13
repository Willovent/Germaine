using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Setting.Details
{
   public class ControlButton : KodiRpc.Setting.Details.ControlHeading
   {
       public KodiRpc.Setting.Details.ControlButton_type type { get; set; }
    }
}
