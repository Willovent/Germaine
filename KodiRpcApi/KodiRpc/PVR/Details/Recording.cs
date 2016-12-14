using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.PVR.Details
{
   public class Recording : KodiRpc.Item.Details.Base
   {
       public KodiRpc.Media.Artwork art { get; set; }
       public string channel { get; set; }
       public int channeluid { get; set; }
       public string directory { get; set; }
       public string endtime { get; set; }
       public int epgeventid { get; set; }
       public string file { get; set; }
       public string genre { get; set; }
       public string icon { get; set; }
       public bool isdeleted { get; set; }
       public int lifetime { get; set; }
       public int playcount { get; set; }
       public string plot { get; set; }
       public string plotoutline { get; set; }
       public bool radio { get; set; }
       public int recordingid { get; set; }
       public KodiRpc.Video.Resume resume { get; set; }
       public int runtime { get; set; }
       public string starttime { get; set; }
       public string streamurl { get; set; }
       public string title { get; set; }
    }
}
