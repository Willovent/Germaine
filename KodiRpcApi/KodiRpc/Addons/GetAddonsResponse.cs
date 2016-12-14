using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Addons
{
   public class GetAddonsResponse
   {
       public global::System.Collections.Generic.List<KodiRpc.Addon.Details> addons { get; set; }
       public KodiRpc.List.LimitsReturned limits { get; set; }
    }
}
