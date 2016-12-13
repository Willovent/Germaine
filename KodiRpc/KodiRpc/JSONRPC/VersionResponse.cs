using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.JSONRPC
{
   public class VersionResponse
   {
       public KodiRpc.JSONRPC.VersionResponse_version version { get; set; }
    }
}
