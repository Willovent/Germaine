using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Notifications
{
   public class Item5
   {
       public string album { get; set; }
       public string artist { get; set; }
       public string title { get; set; }
       public int track { get; set; }
       public KodiRpc.Notifications.Item.Type type { get; set; }
    }
}
