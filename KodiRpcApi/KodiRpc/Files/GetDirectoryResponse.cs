using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Files
{
   public class GetDirectoryResponse
   {
       public global::System.Collections.Generic.List<KodiRpc.List.Item.File> files { get; set; }
       public KodiRpc.List.LimitsReturned limits { get; set; }
    }
}
