using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Audio.Details
{
   public class Media : KodiRpc.Audio.Details.Base
   {
       public global::System.Collections.Generic.List<string> artist { get; set; }
       public global::System.Collections.Generic.List<int> artistid { get; set; }
       public string displayartist { get; set; }
       public global::System.Collections.Generic.List<int> genreid { get; set; }
       public string musicbrainzalbumartistid { get; set; }
       public string musicbrainzalbumid { get; set; }
       public double rating { get; set; }
       public string title { get; set; }
       public int userrating { get; set; }
       public int votes { get; set; }
       public int year { get; set; }
    }
}
