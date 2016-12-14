using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.List.Filter
{
   public class Rule
   {
       [Newtonsoft.Json.JsonProperty("operator")]
       public KodiRpc.List.Filter.Operators Operator { get; set; }
       public object value { get; set; }
   public class Albums : KodiRpc.List.Filter.Rule
   {
       public KodiRpc.List.Filter.Fields.Albums field { get; set; }
    }
   public class Artists : KodiRpc.List.Filter.Rule
   {
       public KodiRpc.List.Filter.Fields.Artists field { get; set; }
    }
   public class Episodes : KodiRpc.List.Filter.Rule
   {
       public KodiRpc.List.Filter.Fields.Episodes field { get; set; }
    }
   public class Movies : KodiRpc.List.Filter.Rule
   {
       public KodiRpc.List.Filter.Fields.Movies field { get; set; }
    }
   public class MusicVideos : KodiRpc.List.Filter.Rule
   {
       public KodiRpc.List.Filter.Fields.MusicVideos field { get; set; }
    }
   public class Songs : KodiRpc.List.Filter.Rule
   {
       public KodiRpc.List.Filter.Fields.Songs field { get; set; }
    }
   public class TVShows : KodiRpc.List.Filter.Rule
   {
       public KodiRpc.List.Filter.Fields.TVShows field { get; set; }
    }
   public class Textures : KodiRpc.List.Filter.Rule
   {
       public KodiRpc.List.Filter.Fields.Textures field { get; set; }
    }
    }
}
