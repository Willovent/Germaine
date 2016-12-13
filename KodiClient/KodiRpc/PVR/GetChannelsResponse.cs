using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.PVR
{
   public class GetChannelsResponse
   {
       public global::System.Collections.Generic.List<KodiRpc.PVR.Details.Channel> channels { get; set; }
       public KodiRpc.List.LimitsReturned limits { get; set; }
    }
}
