using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
#pragma warning disable CS0108

namespace KodiRpc.Methods
{
   public partial class Files
   {
        private readonly Client _client;
          public Files(Client client)
          {
              _client = client;
          }

                /// <summary>
                /// Get the directories and files in the given directory
                /// </summary>
                /// <param name="directory"> REQUIRED </param>
                /// <param name="media"> </param>
                /// <param name="properties"> </param>
                /// <param name="sort"> </param>
                /// <param name="limits"> Limits are applied after getting the directory content thus retrieval is not faster when they are applied.</param>
                /// <returns>KodiRpc.Files.GetDirectoryResponse</returns>
        public async Task<KodiRpc.Files.GetDirectoryResponse> GetDirectory(string directory=null, KodiRpc.Files.Media? media=null, KodiRpc.List.Fields.Files properties=null, KodiRpc.List.Sort sort=null, KodiRpc.List.Limits limits=null)
        {
             var jArgs = new JObject();

             if (directory == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null directory");
              }
             else
              {
                 var jpropdirectory = JToken.FromObject(directory, _client.Serializer);
                 jArgs.Add(new JProperty("directory", jpropdirectory));
              }
             if (media != null)
             {
                 var jpropmedia = JToken.FromObject(media, _client.Serializer);
                 jArgs.Add(new JProperty("media", jpropmedia));
             }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
             if (sort != null)
             {
                 var jpropsort = JToken.FromObject(sort, _client.Serializer);
                 jArgs.Add(new JProperty("sort", jpropsort));
             }
             if (limits != null)
             {
                 var jproplimits = JToken.FromObject(limits, _client.Serializer);
                 jArgs.Add(new JProperty("limits", jproplimits));
             }
            return await _client.GetData<KodiRpc.Files.GetDirectoryResponse>("Files.GetDirectory", jArgs);
        }

                /// <summary>
                /// Get details for a specific file
                /// </summary>
                /// <param name="file"> REQUIRED Full path to the file</param>
                /// <param name="media"> </param>
                /// <param name="properties"> </param>
                /// <returns>KodiRpc.Files.GetFileDetailsResponse</returns>
        public async Task<KodiRpc.Files.GetFileDetailsResponse> GetFileDetails(string file=null, KodiRpc.Files.Media? media=null, KodiRpc.List.Fields.Files properties=null)
        {
             var jArgs = new JObject();

             if (file == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null file");
              }
             else
              {
                 var jpropfile = JToken.FromObject(file, _client.Serializer);
                 jArgs.Add(new JProperty("file", jpropfile));
              }
             if (media != null)
             {
                 var jpropmedia = JToken.FromObject(media, _client.Serializer);
                 jArgs.Add(new JProperty("media", jpropmedia));
             }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
            return await _client.GetData<KodiRpc.Files.GetFileDetailsResponse>("Files.GetFileDetails", jArgs);
        }

                /// <summary>
                /// Get the sources of the media windows
                /// </summary>
                /// <param name="media"> REQUIRED </param>
                /// <param name="limits"> </param>
                /// <param name="sort"> </param>
                /// <returns>KodiRpc.Files.GetSourcesResponse</returns>
        public async Task<KodiRpc.Files.GetSourcesResponse> GetSources(KodiRpc.Files.Media? media=null, KodiRpc.List.Limits limits=null, KodiRpc.List.Sort sort=null)
        {
             var jArgs = new JObject();

             if (media == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null media");
              }
             else
              {
                 var jpropmedia = JToken.FromObject(media, _client.Serializer);
                 jArgs.Add(new JProperty("media", jpropmedia));
              }
             if (limits != null)
             {
                 var jproplimits = JToken.FromObject(limits, _client.Serializer);
                 jArgs.Add(new JProperty("limits", jproplimits));
             }
             if (sort != null)
             {
                 var jpropsort = JToken.FromObject(sort, _client.Serializer);
                 jArgs.Add(new JProperty("sort", jpropsort));
             }
            return await _client.GetData<KodiRpc.Files.GetSourcesResponse>("Files.GetSources", jArgs);
        }

                /// <summary>
                /// Provides a way to download a given file (e.g. providing an URL to the real file location)
                /// </summary>
                /// <param name="path"> REQUIRED </param>
                /// <returns>KodiRpc.Files.PrepareDownloadResponse</returns>
        public async Task<KodiRpc.Files.PrepareDownloadResponse> PrepareDownload(string path=null)
        {
             var jArgs = new JObject();

             if (path == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null path");
              }
             else
              {
                 var jproppath = JToken.FromObject(path, _client.Serializer);
                 jArgs.Add(new JProperty("path", jproppath));
              }
            return await _client.GetData<KodiRpc.Files.PrepareDownloadResponse>("Files.PrepareDownload", jArgs);
        }

                /// <summary>
                /// Update the given specific file with the given details
                /// </summary>
                /// <param name="file"> REQUIRED Full path to the file</param>
                /// <param name="media"> REQUIRED File type to update correct database. Currently only "video" is supported.</param>
                /// <param name="playcount"> </param>
                /// <param name="lastplayed"> Setting a valid lastplayed without a playcount will force playcount to 1.</param>
                /// <param name="resume"> </param>
                /// <returns>string</returns>
        public async Task<string> SetFileDetails(string file=null, KodiRpc.Files.Media? media=null, int? playcount=null, string lastplayed=null, KodiRpc.Video.Resume resume=null)
        {
             var jArgs = new JObject();

             if (file == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null file");
              }
             else
              {
                 var jpropfile = JToken.FromObject(file, _client.Serializer);
                 jArgs.Add(new JProperty("file", jpropfile));
              }
             if (media == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null media");
              }
             else
              {
                 var jpropmedia = JToken.FromObject(media, _client.Serializer);
                 jArgs.Add(new JProperty("media", jpropmedia));
              }
             if (playcount != null)
             {
                 var jpropplaycount = JToken.FromObject(playcount, _client.Serializer);
                 jArgs.Add(new JProperty("playcount", jpropplaycount));
             }
             if (lastplayed != null)
             {
                 var jproplastplayed = JToken.FromObject(lastplayed, _client.Serializer);
                 jArgs.Add(new JProperty("lastplayed", jproplastplayed));
             }
             if (resume != null)
             {
                 var jpropresume = JToken.FromObject(resume, _client.Serializer);
                 jArgs.Add(new JProperty("resume", jpropresume));
             }
            return await _client.GetData<string>("Files.SetFileDetails", jArgs);
        }
   }
}
