using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Setting.Details
{
   public class SettingAddon : KodiRpc.Setting.Details.SettingString
   {
       public KodiRpc.Addon.Types addontype { get; set; }
    }
}
