using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.VideoLibrary
{
   public class GetMovieDetailsResponse
   {
       public KodiRpc.Video.Details.Movie moviedetails { get; set; }
    }
}
