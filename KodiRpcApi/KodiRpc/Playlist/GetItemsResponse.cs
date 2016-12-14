using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Playlist
{
   public class GetItemsResponse
   {
       public global::System.Collections.Generic.List<KodiRpc.List.Item.All> items { get; set; }
       public KodiRpc.List.LimitsReturned limits { get; set; }
    }
}
