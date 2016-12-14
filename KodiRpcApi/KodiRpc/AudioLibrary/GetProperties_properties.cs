using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.AudioLibrary
{
   public class GetProperties_properties : global::System.Collections.Generic.List<KodiRpc.Audio.Property.Name>
   {
         public static GetProperties_properties AllFields()
         {
             var items = Enum.GetValues(typeof (KodiRpc.Audio.Property.Name));
             var list = new GetProperties_properties();
             list.AddRange(items.Cast<KodiRpc.Audio.Property.Name>());
             return list;
         }
   }
}
