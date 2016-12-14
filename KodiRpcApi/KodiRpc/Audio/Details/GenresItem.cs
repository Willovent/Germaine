using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Audio.Details
{
   public class GenresItem
   {
       public int genreid { get; set; }
       public string title { get; set; }
    }
}
