using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.List
{
   public class Sort
   {
       public bool ignorearticle { get; set; }
       public KodiRpc.List.Sort_method method { get; set; }
       public KodiRpc.List.Sort_order order { get; set; }
    }
}
