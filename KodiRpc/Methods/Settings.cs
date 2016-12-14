using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
#pragma warning disable CS0108

namespace KodiRpc.Methods
{
   public partial class Settings
   {
        private readonly Client _client;
          public Settings(Client client)
          {
              _client = client;
          }

                /// <summary>
                /// Retrieves all setting categories
                /// </summary>
                /// <param name="level"> </param>
                /// <param name="section"> </param>
                /// <param name="properties"> </param>
                /// <returns>KodiRpc.Settings.GetCategoriesResponse</returns>
        public async Task<KodiRpc.Settings.GetCategoriesResponse> GetCategories(KodiRpc.Setting.Level? level=null, string section=null, KodiRpc.Settings.GetCategories_properties properties=null)
        {
             var jArgs = new JObject();

             if (level != null)
             {
                 var jproplevel = JToken.FromObject(level, _client.Serializer);
                 jArgs.Add(new JProperty("level", jproplevel));
             }
             if (section != null)
             {
                 var jpropsection = JToken.FromObject(section, _client.Serializer);
                 jArgs.Add(new JProperty("section", jpropsection));
             }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
            return await _client.GetData<KodiRpc.Settings.GetCategoriesResponse>("Settings.GetCategories", jArgs);
        }

                /// <summary>
                /// Retrieves all setting sections
                /// </summary>
                /// <param name="level"> </param>
                /// <param name="properties"> </param>
                /// <returns>KodiRpc.Settings.GetSectionsResponse</returns>
        public async Task<KodiRpc.Settings.GetSectionsResponse> GetSections(KodiRpc.Setting.Level? level=null, KodiRpc.Settings.GetSections_properties properties=null)
        {
             var jArgs = new JObject();

             if (level != null)
             {
                 var jproplevel = JToken.FromObject(level, _client.Serializer);
                 jArgs.Add(new JProperty("level", jproplevel));
             }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
            return await _client.GetData<KodiRpc.Settings.GetSectionsResponse>("Settings.GetSections", jArgs);
        }

                /// <summary>
                /// Retrieves the value of a setting
                /// </summary>
                /// <param name="setting"> REQUIRED </param>
                /// <returns>KodiRpc.Settings.GetSettingValueResponse</returns>
        public async Task<KodiRpc.Settings.GetSettingValueResponse> GetSettingValue(string setting=null)
        {
             var jArgs = new JObject();

             if (setting == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null setting");
              }
             else
              {
                 var jpropsetting = JToken.FromObject(setting, _client.Serializer);
                 jArgs.Add(new JProperty("setting", jpropsetting));
              }
            return await _client.GetData<KodiRpc.Settings.GetSettingValueResponse>("Settings.GetSettingValue", jArgs);
        }

                /// <summary>
                /// Retrieves all settings
                /// </summary>
                /// <param name="level"> </param>
                /// <param name="filter"> </param>
                /// <returns>KodiRpc.Settings.GetSettingsResponse</returns>
        public async Task<KodiRpc.Settings.GetSettingsResponse> GetSettings(KodiRpc.Setting.Level? level=null, KodiRpc.Settings.GetSettings_filter1 filter=null)
        {
             var jArgs = new JObject();

             if (level != null)
             {
                 var jproplevel = JToken.FromObject(level, _client.Serializer);
                 jArgs.Add(new JProperty("level", jproplevel));
             }
             if (filter != null)
             {
                 var jpropfilter = JToken.FromObject(filter, _client.Serializer);
                 jArgs.Add(new JProperty("filter", jpropfilter));
             }
            return await _client.GetData<KodiRpc.Settings.GetSettingsResponse>("Settings.GetSettings", jArgs);
        }

                /// <summary>
                /// Retrieves all settings
                /// </summary>
                /// <param name="level"> </param>
                /// <returns>KodiRpc.Settings.GetSettingsResponse</returns>
        public async Task<KodiRpc.Settings.GetSettingsResponse> GetSettings(KodiRpc.Setting.Level? level=null)
        {
             var jArgs = new JObject();

             if (level != null)
             {
                 var jproplevel = JToken.FromObject(level, _client.Serializer);
                 jArgs.Add(new JProperty("level", jproplevel));
             }
            return await _client.GetData<KodiRpc.Settings.GetSettingsResponse>("Settings.GetSettings", jArgs);
        }

                /// <summary>
                /// Resets the value of a setting
                /// </summary>
                /// <param name="setting"> REQUIRED </param>
                /// <returns>string</returns>
        public async Task<string> ResetSettingValue(string setting=null)
        {
             var jArgs = new JObject();

             if (setting == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null setting");
              }
             else
              {
                 var jpropsetting = JToken.FromObject(setting, _client.Serializer);
                 jArgs.Add(new JProperty("setting", jpropsetting));
              }
            return await _client.GetData<string>("Settings.ResetSettingValue", jArgs);
        }

                /// <summary>
                /// Changes the value of a setting
                /// </summary>
                /// <param name="setting"> REQUIRED </param>
                /// <param name="value"> REQUIRED </param>
                /// <returns>bool</returns>
        public async Task<bool> SetSettingValue(string setting=null, bool? value=null)
        {
             var jArgs = new JObject();

             if (setting == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null setting");
              }
             else
              {
                 var jpropsetting = JToken.FromObject(setting, _client.Serializer);
                 jArgs.Add(new JProperty("setting", jpropsetting));
              }
             if (value == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null value");
              }
             else
              {
                 var jpropvalue = JToken.FromObject(value, _client.Serializer);
                 jArgs.Add(new JProperty("value", jpropvalue));
              }
            return await _client.GetData<bool>("Settings.SetSettingValue", jArgs);
        }

                /// <summary>
                /// Changes the value of a setting
                /// </summary>
                /// <param name="setting"> REQUIRED </param>
                /// <param name="value"> REQUIRED </param>
                /// <returns>bool</returns>
        public async Task<bool> SetSettingValue(string setting=null, int? value=null)
        {
             var jArgs = new JObject();

             if (setting == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null setting");
              }
             else
              {
                 var jpropsetting = JToken.FromObject(setting, _client.Serializer);
                 jArgs.Add(new JProperty("setting", jpropsetting));
              }
             if (value == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null value");
              }
             else
              {
                 var jpropvalue = JToken.FromObject(value, _client.Serializer);
                 jArgs.Add(new JProperty("value", jpropvalue));
              }
            return await _client.GetData<bool>("Settings.SetSettingValue", jArgs);
        }

                /// <summary>
                /// Changes the value of a setting
                /// </summary>
                /// <param name="setting"> REQUIRED </param>
                /// <param name="value"> REQUIRED </param>
                /// <returns>bool</returns>
        public async Task<bool> SetSettingValue(string setting=null, double? value=null)
        {
             var jArgs = new JObject();

             if (setting == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null setting");
              }
             else
              {
                 var jpropsetting = JToken.FromObject(setting, _client.Serializer);
                 jArgs.Add(new JProperty("setting", jpropsetting));
              }
             if (value == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null value");
              }
             else
              {
                 var jpropvalue = JToken.FromObject(value, _client.Serializer);
                 jArgs.Add(new JProperty("value", jpropvalue));
              }
            return await _client.GetData<bool>("Settings.SetSettingValue", jArgs);
        }

                /// <summary>
                /// Changes the value of a setting
                /// </summary>
                /// <param name="setting"> REQUIRED </param>
                /// <param name="value"> REQUIRED </param>
                /// <returns>bool</returns>
        public async Task<bool> SetSettingValue(string setting=null, string value=null)
        {
             var jArgs = new JObject();

             if (setting == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null setting");
              }
             else
              {
                 var jpropsetting = JToken.FromObject(setting, _client.Serializer);
                 jArgs.Add(new JProperty("setting", jpropsetting));
              }
             if (value == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null value");
              }
             else
              {
                 var jpropvalue = JToken.FromObject(value, _client.Serializer);
                 jArgs.Add(new JProperty("value", jpropvalue));
              }
            return await _client.GetData<bool>("Settings.SetSettingValue", jArgs);
        }

                /// <summary>
                /// Changes the value of a setting
                /// </summary>
                /// <param name="setting"> REQUIRED </param>
                /// <param name="value"> REQUIRED </param>
                /// <returns>bool</returns>
        public async Task<bool> SetSettingValue(string setting=null, global::System.Collections.Generic.List<object> value=null)
        {
             var jArgs = new JObject();

             if (setting == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null setting");
              }
             else
              {
                 var jpropsetting = JToken.FromObject(setting, _client.Serializer);
                 jArgs.Add(new JProperty("setting", jpropsetting));
              }
             if (value == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null value");
              }
             else
              {
                 var jpropvalue = JToken.FromObject(value, _client.Serializer);
                 jArgs.Add(new JProperty("value", jpropvalue));
              }
            return await _client.GetData<bool>("Settings.SetSettingValue", jArgs);
        }

                /// <summary>
                /// Changes the value of a setting
                /// </summary>
                /// <param name="setting"> REQUIRED </param>
                /// <returns>bool</returns>
        public async Task<bool> SetSettingValue(string setting=null)
        {
             var jArgs = new JObject();

             if (setting == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null setting");
              }
             else
              {
                 var jpropsetting = JToken.FromObject(setting, _client.Serializer);
                 jArgs.Add(new JProperty("setting", jpropsetting));
              }
            return await _client.GetData<bool>("Settings.SetSettingValue", jArgs);
        }
   }
}
