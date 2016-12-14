using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Favourites
{
   public class GetFavouritesResponse
   {
       public global::System.Collections.Generic.List<KodiRpc.Favourite.Details.Favourite> favourites { get; set; }
       public KodiRpc.List.LimitsReturned limits { get; set; }
    }
}
