using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.PVR.Details
{
   public class Timer : KodiRpc.Item.Details.Base
   {
       public int channelid { get; set; }
       public string directory { get; set; }
       public bool endanytime { get; set; }
       public int endmargin { get; set; }
       public string endtime { get; set; }
       public string epgsearchstring { get; set; }
       public int epguid { get; set; }
       public string file { get; set; }
       public string firstday { get; set; }
       public bool fulltextepgsearch { get; set; }
       public bool ismanual { get; set; }
       public bool isradio { get; set; }
       public bool isreadonly { get; set; }
       public bool istimerrule { get; set; }
       public int lifetime { get; set; }
       public int maxrecordings { get; set; }
       public int preventduplicateepisodes { get; set; }
       public int priority { get; set; }
       public int recordinggroup { get; set; }
       public int runtime { get; set; }
       public bool startanytime { get; set; }
       public int startmargin { get; set; }
       public string starttime { get; set; }
       public KodiRpc.PVR.TimerState state { get; set; }
       public string summary { get; set; }
       public int timerid { get; set; }
       public string title { get; set; }
       public KodiRpc.PVR.Details.Timer_weekdays weekdays { get; set; }
    }
}
