using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Video.Details
{
   public class MovieSet : KodiRpc.Video.Details.Media
   {
       public string plot { get; set; }
       public int setid { get; set; }
   public class Extended : KodiRpc.Video.Details.MovieSet
   {
       public KodiRpc.List.LimitsReturned limits { get; set; }
       public global::System.Collections.Generic.List<KodiRpc.Video.Details.Movie> movies { get; set; }
    }
    }
}
