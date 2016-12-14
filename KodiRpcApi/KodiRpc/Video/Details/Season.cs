using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Video.Details
{
   public class Season : KodiRpc.Video.Details.Base
   {
       public int episode { get; set; }
       public int season { get; set; }
       public int seasonid { get; set; }
       public string showtitle { get; set; }
       public int tvshowid { get; set; }
       public int userrating { get; set; }
       public int watchedepisodes { get; set; }
    }
}
