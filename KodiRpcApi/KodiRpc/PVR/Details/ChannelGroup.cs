using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.PVR.Details
{
   public class ChannelGroup : KodiRpc.Item.Details.Base
   {
       public int channelgroupid { get; set; }
       public KodiRpc.PVR.Channel.Type channeltype { get; set; }
   public class Extended : KodiRpc.PVR.Details.ChannelGroup
   {
       public global::System.Collections.Generic.List<KodiRpc.PVR.Details.Channel> channels { get; set; }
       public KodiRpc.List.LimitsReturned limits { get; set; }
    }
    }
}
