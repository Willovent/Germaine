using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Player
{
   public class SeekResponse
   {
       public double percentage { get; set; }
       public KodiRpc.Global.Time time { get; set; }
       public KodiRpc.Global.Time totaltime { get; set; }
    }
}
