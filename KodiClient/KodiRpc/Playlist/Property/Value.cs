using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Playlist.Property
{
   public class Value
   {
       public int size { get; set; }
       public KodiRpc.Playlist.Type type { get; set; }
    }
}
