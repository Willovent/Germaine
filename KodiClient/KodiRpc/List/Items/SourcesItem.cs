using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.List.Items
{
   public class SourcesItem : KodiRpc.Item.Details.Base
   {
       public string file { get; set; }
    }
}
