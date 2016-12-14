using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.GUI.Property
{
   public class Value
   {
       public KodiRpc.GUI.Property.Value_currentcontrol currentcontrol { get; set; }
       public KodiRpc.GUI.Property.Value_currentwindow currentwindow { get; set; }
       public bool fullscreen { get; set; }
       public KodiRpc.GUI.Property.Value_skin skin { get; set; }
       public KodiRpc.GUI.Stereoscopy.Mode stereoscopicmode { get; set; }
    }
}
