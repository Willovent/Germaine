using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Player.Notifications
{
   public class Player
   {
       public int playerid { get; set; }
       public int speed { get; set; }
   public class Seek : KodiRpc.Player.Notifications.Player
   {
       public KodiRpc.Global.Time seekoffset { get; set; }
       public KodiRpc.Global.Time time { get; set; }
    }
    }
}
