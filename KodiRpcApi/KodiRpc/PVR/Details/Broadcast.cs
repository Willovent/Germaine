using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.PVR.Details
{
   public class Broadcast : KodiRpc.Item.Details.Base
   {
       public int broadcastid { get; set; }
       public string cast { get; set; }
       public string director { get; set; }
       public string endtime { get; set; }
       public string episodename { get; set; }
       public int episodenum { get; set; }
       public int episodepart { get; set; }
       public string firstaired { get; set; }
       public string genre { get; set; }
       public bool hasrecording { get; set; }
       public bool hastimer { get; set; }
       public bool hastimerrule { get; set; }
       public int imdbnumber { get; set; }
       public bool isactive { get; set; }
       public bool isseries { get; set; }
       public string originaltitle { get; set; }
       public int parentalrating { get; set; }
       public string plot { get; set; }
       public string plotoutline { get; set; }
       public int progress { get; set; }
       public double progresspercentage { get; set; }
       public int rating { get; set; }
       public string recording { get; set; }
       public int runtime { get; set; }
       public string starttime { get; set; }
       public string thumbnail { get; set; }
       public string title { get; set; }
       public bool wasactive { get; set; }
       public string writer { get; set; }
       public int year { get; set; }
    }
}
