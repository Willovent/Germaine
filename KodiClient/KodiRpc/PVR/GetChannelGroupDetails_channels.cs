using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.PVR
{
   public class GetChannelGroupDetails_channels
   {
       public KodiRpc.List.Limits limits { get; set; }
       public KodiRpc.PVR.Fields.Channel properties { get; set; }
    }
}
