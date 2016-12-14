using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.List.Filter.Fields
{
   public enum Albums
   {
       genre,
       album,
       artist,
       albumartist,
       year,
       review,
       themes,
       moods,
       styles,
       compilation,
       type,
       label,
       rating,
       userrating,
       playcount,
       lastplayed,
       path,
       playlist,
       virtualfolder,
   }
}
