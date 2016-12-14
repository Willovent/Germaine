using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.System
{
   public class GetProperties_properties : global::System.Collections.Generic.List<KodiRpc.System.Property.Name>
   {
         public static GetProperties_properties AllFields()
         {
             var items = Enum.GetValues(typeof (KodiRpc.System.Property.Name));
             var list = new GetProperties_properties();
             list.AddRange(items.Cast<KodiRpc.System.Property.Name>());
             return list;
         }
   }
}
