using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Video.Details
{
   public class File : KodiRpc.Video.Details.Item
   {
       public global::System.Collections.Generic.List<string> director { get; set; }
       public KodiRpc.Video.Resume resume { get; set; }
       public int runtime { get; set; }
       public KodiRpc.Video.Streams streamdetails { get; set; }
    }
}
