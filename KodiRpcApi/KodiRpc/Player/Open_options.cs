using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Player
{
   public class Open_options
   {
       public object playername { get; set; }
       public object repeat { get; set; }
       public object resume { get; set; }
       public bool shuffled { get; set; }
    }
}
