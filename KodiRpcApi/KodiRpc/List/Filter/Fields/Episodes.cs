using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.List.Filter.Fields
{
   public enum Episodes
   {
       title,
       tvshow,
       plot,
       votes,
       rating,
       userrating,
       time,
       writers,
       airdate,
       playcount,
       lastplayed,
       inprogress,
       genre,
       year,
       director,
       actor,
       episode,
       season,
       filename,
       path,
       studio,
       mpaarating,
       dateadded,
       tag,
       videoresolution,
       audiochannels,
       audiocount,
       subtitlecount,
       videocodec,
       audiocodec,
       audiolanguage,
       subtitlelanguage,
       videoaspect,
       playlist,
       virtualfolder,
   }
}
