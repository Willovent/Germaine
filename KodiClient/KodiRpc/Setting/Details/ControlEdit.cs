using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Setting.Details
{
   public class ControlEdit : KodiRpc.Setting.Details.ControlHeading
   {
       public bool hidden { get; set; }
       public KodiRpc.Setting.Details.ControlEdit_type type { get; set; }
       public bool verifynewvalue { get; set; }
    }
}
