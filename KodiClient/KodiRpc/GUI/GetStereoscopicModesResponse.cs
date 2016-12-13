using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KodiRpc.GUI
{
   public class GetStereoscopicModesResponse
   {
       public global::System.Collections.Generic.List<KodiRpc.GUI.Stereoscopy.Mode> stereoscopicmodes { get; set; }
    }
}
