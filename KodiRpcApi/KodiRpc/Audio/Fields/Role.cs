using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Audio.Fields
{
   public enum RoleItem
   {
       title,
   }
   public class Role : List<RoleItem>
   {
         public static Role AllFields()
         {
             var items = Enum.GetValues(typeof (RoleItem));
             var list = new Role();
             list.AddRange(items.Cast<RoleItem>());
             return list;
         }
   }
}
