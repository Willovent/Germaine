using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.AudioLibrary
{
   public class GetArtists_filter2
   {
       public string role { get; set; }
       public int songgenreid { get; set; }
    }
}
