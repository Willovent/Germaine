using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Settings
{
   public class GetSectionsResponse
   {
       public global::System.Collections.Generic.List<KodiRpc.Setting.Details.Section> sections { get; set; }
    }
}
