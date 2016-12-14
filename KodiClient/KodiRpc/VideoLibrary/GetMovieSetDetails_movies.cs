using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.VideoLibrary
{
   public class GetMovieSetDetails_movies
   {
       public KodiRpc.List.Limits limits { get; set; }
       public KodiRpc.Video.Fields.Movie properties { get; set; }
       public KodiRpc.List.Sort sort { get; set; }
    }
}
