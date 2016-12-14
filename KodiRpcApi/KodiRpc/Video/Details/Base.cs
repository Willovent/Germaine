using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Video.Details
{
   public class Base : KodiRpc.Media.Details.Base
   {
       public KodiRpc.Media.Artwork art { get; set; }
       public int playcount { get; set; }
    }
}
