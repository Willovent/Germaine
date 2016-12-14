using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Player.Video
{
   public class Stream
   {
       public string codec { get; set; }
       public int height { get; set; }
       public int index { get; set; }
       public string language { get; set; }
       public string name { get; set; }
       public int width { get; set; }
    }
}
