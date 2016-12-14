using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.Library.Fields
{
   public enum TagItem
   {
       title,
   }
   public class Tag : List<TagItem>
   {
         public static Tag AllFields()
         {
             var items = Enum.GetValues(typeof (TagItem));
             var list = new Tag();
             list.AddRange(items.Cast<TagItem>());
             return list;
         }
   }
}
