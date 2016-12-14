using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Audio
{
   public class ContributorsItem
   {
       public int artistid { get; set; }
       public string name { get; set; }
       public string role { get; set; }
       public int roleid { get; set; }
    }
}
