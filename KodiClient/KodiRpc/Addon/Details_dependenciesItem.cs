using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Addon
{
   public class Details_dependenciesItem
   {
       public string addonid { get; set; }
       public bool optional { get; set; }
       public string version { get; set; }
    }
}
