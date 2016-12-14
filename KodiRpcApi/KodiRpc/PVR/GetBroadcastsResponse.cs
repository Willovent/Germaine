using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.PVR
{
   public class GetBroadcastsResponse
   {
       public global::System.Collections.Generic.List<KodiRpc.PVR.Details.Broadcast> broadcasts { get; set; }
       public KodiRpc.List.LimitsReturned limits { get; set; }
    }
}
