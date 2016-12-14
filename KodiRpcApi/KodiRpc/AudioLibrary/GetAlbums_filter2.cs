using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.AudioLibrary
{
   public class GetAlbums_filter2
   {
       public int artistid { get; set; }
       public string role { get; set; }
    }
}
