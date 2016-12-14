using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Video.Details
{
   public class TVShow : KodiRpc.Video.Details.Item
   {
       public global::System.Collections.Generic.List<KodiRpc.Video.CastItem> cast { get; set; }
       public int episode { get; set; }
       public string episodeguide { get; set; }
       public global::System.Collections.Generic.List<string> genre { get; set; }
       public string imdbnumber { get; set; }
       public string mpaa { get; set; }
       public string originaltitle { get; set; }
       public string premiered { get; set; }
       public double rating { get; set; }
       public object ratings { get; set; }
       public int runtime { get; set; }
       public int season { get; set; }
       public string sorttitle { get; set; }
       public global::System.Collections.Generic.List<string> studio { get; set; }
       public global::System.Collections.Generic.List<string> tag { get; set; }
       public int tvshowid { get; set; }
       public KodiRpc.Media.UniqueID uniqueid { get; set; }
       public int userrating { get; set; }
       public string votes { get; set; }
       public int watchedepisodes { get; set; }
       public int year { get; set; }
    }
}
