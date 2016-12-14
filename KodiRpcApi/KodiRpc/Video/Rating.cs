using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Video
{
   public class Rating
   {
       [Newtonsoft.Json.JsonProperty("default")]
       public bool Default { get; set; }
       public double rating { get; set; }
       public int votes { get; set; }
    }
}
