using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.PVR.Details
{
   public class Channel : KodiRpc.Item.Details.Base
   {
       public KodiRpc.PVR.Details.Broadcast broadcastnext { get; set; }
       public KodiRpc.PVR.Details.Broadcast broadcastnow { get; set; }
       public string channel { get; set; }
       public int channelid { get; set; }
       public int channelnumber { get; set; }
       public KodiRpc.PVR.Channel.Type channeltype { get; set; }
       public bool hidden { get; set; }
       public string icon { get; set; }
       public bool isrecording { get; set; }
       public string lastplayed { get; set; }
       public bool locked { get; set; }
       public int subchannelnumber { get; set; }
       public string thumbnail { get; set; }
       public int uniqueid { get; set; }
    }
}
