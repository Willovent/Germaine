using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.PVR.Fields
{
   public enum TimerItem
   {
       title,
       summary,
       channelid,
       isradio,
       istimerrule,
       ismanual,
       starttime,
       endtime,
       runtime,
       lifetime,
       firstday,
       weekdays,
       priority,
       startmargin,
       endmargin,
       state,
       file,
       directory,
       preventduplicateepisodes,
       startanytime,
       endanytime,
       epgsearchstring,
       fulltextepgsearch,
       recordinggroup,
       maxrecordings,
       epguid,
       isreadonly,
   }
   public class Timer : List<TimerItem>
   {
         public static Timer AllFields()
         {
             var items = Enum.GetValues(typeof (TimerItem));
             var list = new Timer();
             list.AddRange(items.Cast<TimerItem>());
             return list;
         }
   }
}
