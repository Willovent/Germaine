using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Setting.Details
{
   public class ControlList : KodiRpc.Setting.Details.ControlHeading
   {
       public bool multiselect { get; set; }
       public KodiRpc.Setting.Details.ControlList_type type { get; set; }
    }
}
