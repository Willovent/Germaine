using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Library.Details
{
   public class Genre : KodiRpc.Item.Details.Base
   {
       public int genreid { get; set; }
       public string thumbnail { get; set; }
       public string title { get; set; }
    }
}
