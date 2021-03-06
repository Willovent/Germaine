using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.List.Item
{
   public class File : KodiRpc.List.Item.Base
   {
       public string file { get; set; }
       public KodiRpc.List.Item.File_filetype filetype { get; set; }
       public string lastmodified { get; set; }
       public string mimetype { get; set; }
       public int size { get; set; }
    }
}
