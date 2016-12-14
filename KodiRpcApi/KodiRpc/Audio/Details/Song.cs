using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Audio.Details
{
   public class Song : KodiRpc.Audio.Details.Media
   {
       public string album { get; set; }
       public global::System.Collections.Generic.List<string> albumartist { get; set; }
       public global::System.Collections.Generic.List<int> albumartistid { get; set; }
       public int albumid { get; set; }
       public KodiRpc.Audio.Album.ReleaseType albumreleasetype { get; set; }
       public string comment { get; set; }
       public global::System.Collections.Generic.List<KodiRpc.Audio.ContributorsItem> contributors { get; set; }
       public int disc { get; set; }
       public string displaycomposer { get; set; }
       public string displayconductor { get; set; }
       public string displaylyricist { get; set; }
       public string displayorchestra { get; set; }
       public int duration { get; set; }
       public string file { get; set; }
       public string lastplayed { get; set; }
       public string lyrics { get; set; }
       public string mood { get; set; }
       public string musicbrainzartistid { get; set; }
       public string musicbrainztrackid { get; set; }
       public int playcount { get; set; }
       public int songid { get; set; }
       public int track { get; set; }
    }
}
