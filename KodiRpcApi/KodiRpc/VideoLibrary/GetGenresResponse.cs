using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.VideoLibrary
{
   public class GetGenresResponse
   {
       public global::System.Collections.Generic.List<KodiRpc.Library.Details.Genre> genres { get; set; }
       public KodiRpc.List.LimitsReturned limits { get; set; }
    }
}
