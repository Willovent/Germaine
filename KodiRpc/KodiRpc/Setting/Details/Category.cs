using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Setting.Details
{
   public class Category : KodiRpc.Setting.Details.Base
   {
       public global::System.Collections.Generic.List<KodiRpc.Setting.Details.Group> groups { get; set; }
    }
}
