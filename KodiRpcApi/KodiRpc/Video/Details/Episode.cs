using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Video.Details
{
   public class Episode : KodiRpc.Video.Details.File
   {
       public global::System.Collections.Generic.List<KodiRpc.Video.CastItem> cast { get; set; }
       public int episode { get; set; }
       public int episodeid { get; set; }
       public string firstaired { get; set; }
       public string originaltitle { get; set; }
       public string productioncode { get; set; }
       public double rating { get; set; }
       public object ratings { get; set; }
       public int season { get; set; }
       public int seasonid { get; set; }
       public string showtitle { get; set; }
       public int specialsortepisode { get; set; }
       public int specialsortseason { get; set; }
       public int tvshowid { get; set; }
       public KodiRpc.Media.UniqueID uniqueid { get; set; }
       public int userrating { get; set; }
       public string votes { get; set; }
       public global::System.Collections.Generic.List<string> writer { get; set; }
    }
}
