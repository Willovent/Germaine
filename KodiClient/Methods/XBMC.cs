using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
#pragma warning disable CS0108

namespace KodiRpc.Methods
{
   public partial class XBMC
   {
        private readonly Client _client;
          public XBMC(Client client)
          {
              _client = client;
          }

                /// <summary>
                /// Retrieve info booleans about Kodi and the system
                /// </summary>
                /// <param name="booleans"> REQUIRED </param>
                /// <returns>KodiRpc.XBMC.GetInfoBooleansResponse</returns>
        public async Task<KodiRpc.XBMC.GetInfoBooleansResponse> GetInfoBooleans(global::System.Collections.Generic.List<string> booleans=null)
        {
             var jArgs = new JObject();

             if (booleans == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null booleans");
              }
             else
              {
                 var jpropbooleans = JToken.FromObject(booleans, _client.Serializer);
                 jArgs.Add(new JProperty("booleans", jpropbooleans));
              }
            return await _client.GetData<KodiRpc.XBMC.GetInfoBooleansResponse>("XBMC.GetInfoBooleans", jArgs);
        }

                /// <summary>
                /// Retrieve info labels about Kodi and the system
                /// </summary>
                /// <param name="labels"> REQUIRED See http://kodi.wiki/view/InfoLabels for a list of possible info labels</param>
                /// <returns>KodiRpc.XBMC.GetInfoLabelsResponse</returns>
        public async Task<KodiRpc.XBMC.GetInfoLabelsResponse> GetInfoLabels(global::System.Collections.Generic.List<string> labels=null)
        {
             var jArgs = new JObject();

             if (labels == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null labels");
              }
             else
              {
                 var jproplabels = JToken.FromObject(labels, _client.Serializer);
                 jArgs.Add(new JProperty("labels", jproplabels));
              }
            return await _client.GetData<KodiRpc.XBMC.GetInfoLabelsResponse>("XBMC.GetInfoLabels", jArgs);
        }
   }
}
