using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Profiles
{
   public class Password
   {
       public KodiRpc.Profiles.Password_encryption encryption { get; set; }
       public string value { get; set; }
    }
}
