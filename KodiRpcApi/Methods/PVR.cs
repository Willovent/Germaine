using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
#pragma warning disable CS0108

namespace KodiRpc.Methods
{
   public partial class PVR
   {
        private readonly Client _client;
          public PVR(Client client)
          {
              _client = client;
          }

                /// <summary>
                /// Adds a timer to record the given show one times or a timer rule to record all showings of the given show
                /// </summary>
                /// <param name="broadcastid"> REQUIRED the broadcast id of the item to record</param>
                /// <param name="timerrule"> controls whether to create a timer rule or a onetime timer</param>
                /// <returns>string</returns>
        public async Task<string> AddTimer(int? broadcastid=null, bool? timerrule=null)
        {
             var jArgs = new JObject();

             if (broadcastid == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null broadcastid");
              }
             else
              {
                 var jpropbroadcastid = JToken.FromObject(broadcastid, _client.Serializer);
                 jArgs.Add(new JProperty("broadcastid", jpropbroadcastid));
              }
             if (timerrule != null)
             {
                 var jproptimerrule = JToken.FromObject(timerrule, _client.Serializer);
                 jArgs.Add(new JProperty("timerrule", jproptimerrule));
             }
            return await _client.GetData<string>("PVR.AddTimer", jArgs);
        }

                /// <summary>
                /// Deletes a onetime timer or a timer rule
                /// </summary>
                /// <param name="timerid"> REQUIRED the id of the onetime timer or timer rule to delete</param>
                /// <returns>string</returns>
        public async Task<string> DeleteTimer(int? timerid=null)
        {
             var jArgs = new JObject();

             if (timerid == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null timerid");
              }
             else
              {
                 var jproptimerid = JToken.FromObject(timerid, _client.Serializer);
                 jArgs.Add(new JProperty("timerid", jproptimerid));
              }
            return await _client.GetData<string>("PVR.DeleteTimer", jArgs);
        }

                /// <summary>
                /// Retrieves the details of a specific broadcast
                /// </summary>
                /// <param name="broadcastid"> REQUIRED </param>
                /// <param name="properties"> </param>
                /// <returns>KodiRpc.PVR.GetBroadcastDetailsResponse</returns>
        public async Task<KodiRpc.PVR.GetBroadcastDetailsResponse> GetBroadcastDetails(int? broadcastid=null, KodiRpc.PVR.Fields.Broadcast properties=null)
        {
             var jArgs = new JObject();

             if (broadcastid == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null broadcastid");
              }
             else
              {
                 var jpropbroadcastid = JToken.FromObject(broadcastid, _client.Serializer);
                 jArgs.Add(new JProperty("broadcastid", jpropbroadcastid));
              }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
            return await _client.GetData<KodiRpc.PVR.GetBroadcastDetailsResponse>("PVR.GetBroadcastDetails", jArgs);
        }

                /// <summary>
                /// Retrieves the program of a specific channel
                /// </summary>
                /// <param name="channelid"> REQUIRED </param>
                /// <param name="properties"> </param>
                /// <param name="limits"> </param>
                /// <returns>KodiRpc.PVR.GetBroadcastsResponse</returns>
        public async Task<KodiRpc.PVR.GetBroadcastsResponse> GetBroadcasts(int? channelid=null, KodiRpc.PVR.Fields.Broadcast properties=null, KodiRpc.List.Limits limits=null)
        {
             var jArgs = new JObject();

             if (channelid == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null channelid");
              }
             else
              {
                 var jpropchannelid = JToken.FromObject(channelid, _client.Serializer);
                 jArgs.Add(new JProperty("channelid", jpropchannelid));
              }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
             if (limits != null)
             {
                 var jproplimits = JToken.FromObject(limits, _client.Serializer);
                 jArgs.Add(new JProperty("limits", jproplimits));
             }
            return await _client.GetData<KodiRpc.PVR.GetBroadcastsResponse>("PVR.GetBroadcasts", jArgs);
        }

                /// <summary>
                /// Retrieves the details of a specific channel
                /// </summary>
                /// <param name="channelid"> REQUIRED </param>
                /// <param name="properties"> </param>
                /// <returns>KodiRpc.PVR.GetChannelDetailsResponse</returns>
        public async Task<KodiRpc.PVR.GetChannelDetailsResponse> GetChannelDetails(int? channelid=null, KodiRpc.PVR.Fields.Channel properties=null)
        {
             var jArgs = new JObject();

             if (channelid == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null channelid");
              }
             else
              {
                 var jpropchannelid = JToken.FromObject(channelid, _client.Serializer);
                 jArgs.Add(new JProperty("channelid", jpropchannelid));
              }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
            return await _client.GetData<KodiRpc.PVR.GetChannelDetailsResponse>("PVR.GetChannelDetails", jArgs);
        }

                /// <summary>
                /// Retrieves the details of a specific channel group
                /// </summary>
                /// <param name="channelgroupid"> REQUIRED </param>
                /// <param name="channels"> </param>
                /// <returns>KodiRpc.PVR.GetChannelGroupDetailsResponse</returns>
        public async Task<KodiRpc.PVR.GetChannelGroupDetailsResponse> GetChannelGroupDetails(int? channelgroupid=null, KodiRpc.PVR.GetChannelGroupDetails_channels channels=null)
        {
             var jArgs = new JObject();

             if (channelgroupid == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null channelgroupid");
              }
             else
              {
                 var jpropchannelgroupid = JToken.FromObject(channelgroupid, _client.Serializer);
                 jArgs.Add(new JProperty("channelgroupid", jpropchannelgroupid));
              }
             if (channels != null)
             {
                 var jpropchannels = JToken.FromObject(channels, _client.Serializer);
                 jArgs.Add(new JProperty("channels", jpropchannels));
             }
            return await _client.GetData<KodiRpc.PVR.GetChannelGroupDetailsResponse>("PVR.GetChannelGroupDetails", jArgs);
        }

                /// <summary>
                /// Retrieves the details of a specific channel group
                /// </summary>
                /// <param name="channelgroupid"> REQUIRED </param>
                /// <param name="channels"> </param>
                /// <returns>KodiRpc.PVR.GetChannelGroupDetailsResponse</returns>
        public async Task<KodiRpc.PVR.GetChannelGroupDetailsResponse> GetChannelGroupDetails(KodiRpc.PVR.ChannelGroup.Id1? channelgroupid=null, KodiRpc.PVR.GetChannelGroupDetails_channels channels=null)
        {
             var jArgs = new JObject();

             if (channelgroupid == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null channelgroupid");
              }
             else
              {
                 var jpropchannelgroupid = JToken.FromObject(channelgroupid, _client.Serializer);
                 jArgs.Add(new JProperty("channelgroupid", jpropchannelgroupid));
              }
             if (channels != null)
             {
                 var jpropchannels = JToken.FromObject(channels, _client.Serializer);
                 jArgs.Add(new JProperty("channels", jpropchannels));
             }
            return await _client.GetData<KodiRpc.PVR.GetChannelGroupDetailsResponse>("PVR.GetChannelGroupDetails", jArgs);
        }

                /// <summary>
                /// Retrieves the details of a specific channel group
                /// </summary>
                /// <param name="channels"> </param>
                /// <returns>KodiRpc.PVR.GetChannelGroupDetailsResponse</returns>
        public async Task<KodiRpc.PVR.GetChannelGroupDetailsResponse> GetChannelGroupDetails(KodiRpc.PVR.GetChannelGroupDetails_channels channels=null)
        {
             var jArgs = new JObject();

             if (channels != null)
             {
                 var jpropchannels = JToken.FromObject(channels, _client.Serializer);
                 jArgs.Add(new JProperty("channels", jpropchannels));
             }
            return await _client.GetData<KodiRpc.PVR.GetChannelGroupDetailsResponse>("PVR.GetChannelGroupDetails", jArgs);
        }

                /// <summary>
                /// Retrieves the channel groups for the specified type
                /// </summary>
                /// <param name="channeltype"> REQUIRED </param>
                /// <param name="limits"> </param>
                /// <returns>KodiRpc.PVR.GetChannelGroupsResponse</returns>
        public async Task<KodiRpc.PVR.GetChannelGroupsResponse> GetChannelGroups(KodiRpc.PVR.Channel.Type? channeltype=null, KodiRpc.List.Limits limits=null)
        {
             var jArgs = new JObject();

             if (channeltype == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null channeltype");
              }
             else
              {
                 var jpropchanneltype = JToken.FromObject(channeltype, _client.Serializer);
                 jArgs.Add(new JProperty("channeltype", jpropchanneltype));
              }
             if (limits != null)
             {
                 var jproplimits = JToken.FromObject(limits, _client.Serializer);
                 jArgs.Add(new JProperty("limits", jproplimits));
             }
            return await _client.GetData<KodiRpc.PVR.GetChannelGroupsResponse>("PVR.GetChannelGroups", jArgs);
        }

                /// <summary>
                /// Retrieves the channel list
                /// </summary>
                /// <param name="channelgroupid"> REQUIRED </param>
                /// <param name="properties"> </param>
                /// <param name="limits"> </param>
                /// <returns>KodiRpc.PVR.GetChannelsResponse</returns>
        public async Task<KodiRpc.PVR.GetChannelsResponse> GetChannels(int? channelgroupid=null, KodiRpc.PVR.Fields.Channel properties=null, KodiRpc.List.Limits limits=null)
        {
             var jArgs = new JObject();

             if (channelgroupid == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null channelgroupid");
              }
             else
              {
                 var jpropchannelgroupid = JToken.FromObject(channelgroupid, _client.Serializer);
                 jArgs.Add(new JProperty("channelgroupid", jpropchannelgroupid));
              }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
             if (limits != null)
             {
                 var jproplimits = JToken.FromObject(limits, _client.Serializer);
                 jArgs.Add(new JProperty("limits", jproplimits));
             }
            return await _client.GetData<KodiRpc.PVR.GetChannelsResponse>("PVR.GetChannels", jArgs);
        }

                /// <summary>
                /// Retrieves the channel list
                /// </summary>
                /// <param name="channelgroupid"> REQUIRED </param>
                /// <param name="properties"> </param>
                /// <param name="limits"> </param>
                /// <returns>KodiRpc.PVR.GetChannelsResponse</returns>
        public async Task<KodiRpc.PVR.GetChannelsResponse> GetChannels(KodiRpc.PVR.ChannelGroup.Id1? channelgroupid=null, KodiRpc.PVR.Fields.Channel properties=null, KodiRpc.List.Limits limits=null)
        {
             var jArgs = new JObject();

             if (channelgroupid == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null channelgroupid");
              }
             else
              {
                 var jpropchannelgroupid = JToken.FromObject(channelgroupid, _client.Serializer);
                 jArgs.Add(new JProperty("channelgroupid", jpropchannelgroupid));
              }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
             if (limits != null)
             {
                 var jproplimits = JToken.FromObject(limits, _client.Serializer);
                 jArgs.Add(new JProperty("limits", jproplimits));
             }
            return await _client.GetData<KodiRpc.PVR.GetChannelsResponse>("PVR.GetChannels", jArgs);
        }

                /// <summary>
                /// Retrieves the channel list
                /// </summary>
                /// <param name="properties"> </param>
                /// <param name="limits"> </param>
                /// <returns>KodiRpc.PVR.GetChannelsResponse</returns>
        public async Task<KodiRpc.PVR.GetChannelsResponse> GetChannels(KodiRpc.PVR.Fields.Channel properties=null, KodiRpc.List.Limits limits=null)
        {
             var jArgs = new JObject();

             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
             if (limits != null)
             {
                 var jproplimits = JToken.FromObject(limits, _client.Serializer);
                 jArgs.Add(new JProperty("limits", jproplimits));
             }
            return await _client.GetData<KodiRpc.PVR.GetChannelsResponse>("PVR.GetChannels", jArgs);
        }

                /// <summary>
                /// Retrieves the values of the given properties
                /// </summary>
                /// <param name="properties"> REQUIRED </param>
                /// <returns>KodiRpc.PVR.Property.Value</returns>
        public async Task<KodiRpc.PVR.Property.Value> GetProperties(KodiRpc.PVR.GetProperties_properties properties=null)
        {
             var jArgs = new JObject();

             if (properties == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null properties");
              }
             else
              {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
              }
            return await _client.GetData<KodiRpc.PVR.Property.Value>("PVR.GetProperties", jArgs);
        }

                /// <summary>
                /// Retrieves the details of a specific recording
                /// </summary>
                /// <param name="recordingid"> REQUIRED </param>
                /// <param name="properties"> </param>
                /// <returns>KodiRpc.PVR.GetRecordingDetailsResponse</returns>
        public async Task<KodiRpc.PVR.GetRecordingDetailsResponse> GetRecordingDetails(int? recordingid=null, KodiRpc.PVR.Fields.Recording properties=null)
        {
             var jArgs = new JObject();

             if (recordingid == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null recordingid");
              }
             else
              {
                 var jproprecordingid = JToken.FromObject(recordingid, _client.Serializer);
                 jArgs.Add(new JProperty("recordingid", jproprecordingid));
              }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
            return await _client.GetData<KodiRpc.PVR.GetRecordingDetailsResponse>("PVR.GetRecordingDetails", jArgs);
        }

                /// <summary>
                /// Retrieves the recordings
                /// </summary>
                /// <param name="properties"> </param>
                /// <param name="limits"> </param>
                /// <returns>KodiRpc.PVR.GetRecordingsResponse</returns>
        public async Task<KodiRpc.PVR.GetRecordingsResponse> GetRecordings(KodiRpc.PVR.Fields.Recording properties=null, KodiRpc.List.Limits limits=null)
        {
             var jArgs = new JObject();

             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
             if (limits != null)
             {
                 var jproplimits = JToken.FromObject(limits, _client.Serializer);
                 jArgs.Add(new JProperty("limits", jproplimits));
             }
            return await _client.GetData<KodiRpc.PVR.GetRecordingsResponse>("PVR.GetRecordings", jArgs);
        }

                /// <summary>
                /// Retrieves the details of a specific timer
                /// </summary>
                /// <param name="timerid"> REQUIRED </param>
                /// <param name="properties"> </param>
                /// <returns>KodiRpc.PVR.GetTimerDetailsResponse</returns>
        public async Task<KodiRpc.PVR.GetTimerDetailsResponse> GetTimerDetails(int? timerid=null, KodiRpc.PVR.Fields.Timer properties=null)
        {
             var jArgs = new JObject();

             if (timerid == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null timerid");
              }
             else
              {
                 var jproptimerid = JToken.FromObject(timerid, _client.Serializer);
                 jArgs.Add(new JProperty("timerid", jproptimerid));
              }
             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
            return await _client.GetData<KodiRpc.PVR.GetTimerDetailsResponse>("PVR.GetTimerDetails", jArgs);
        }

                /// <summary>
                /// Retrieves the timers
                /// </summary>
                /// <param name="properties"> </param>
                /// <param name="limits"> </param>
                /// <returns>KodiRpc.PVR.GetTimersResponse</returns>
        public async Task<KodiRpc.PVR.GetTimersResponse> GetTimers(KodiRpc.PVR.Fields.Timer properties=null, KodiRpc.List.Limits limits=null)
        {
             var jArgs = new JObject();

             if (properties != null)
             {
                 var jpropproperties = JToken.FromObject(properties, _client.Serializer);
                 jArgs.Add(new JProperty("properties", jpropproperties));
             }
             if (limits != null)
             {
                 var jproplimits = JToken.FromObject(limits, _client.Serializer);
                 jArgs.Add(new JProperty("limits", jproplimits));
             }
            return await _client.GetData<KodiRpc.PVR.GetTimersResponse>("PVR.GetTimers", jArgs);
        }

                /// <summary>
                /// Toggle recording of a channel
                /// </summary>
                /// <param name="record"> </param>
                /// <param name="channel"> </param>
                /// <returns>string</returns>
        public async Task<string> Record(bool? record=null, object channel=null)
        {
             var jArgs = new JObject();

             if (record != null)
             {
                 var jproprecord = JToken.FromObject(record, _client.Serializer);
                 jArgs.Add(new JProperty("record", jproprecord));
             }
             if (channel != null)
             {
                 var jpropchannel = JToken.FromObject(channel, _client.Serializer);
                 jArgs.Add(new JProperty("channel", jpropchannel));
             }
            return await _client.GetData<string>("PVR.Record", jArgs);
        }

                /// <summary>
                /// Toggle recording of a channel
                /// </summary>
                /// <param name="record"> </param>
                /// <param name="channel"> </param>
                /// <returns>string</returns>
        public async Task<string> Record(KodiRpc.Global.Toggle2? record=null, object channel=null)
        {
             var jArgs = new JObject();

             if (record != null)
             {
                 var jproprecord = JToken.FromObject(record, _client.Serializer);
                 jArgs.Add(new JProperty("record", jproprecord));
             }
             if (channel != null)
             {
                 var jpropchannel = JToken.FromObject(channel, _client.Serializer);
                 jArgs.Add(new JProperty("channel", jpropchannel));
             }
            return await _client.GetData<string>("PVR.Record", jArgs);
        }

                /// <summary>
                /// Toggle recording of a channel
                /// </summary>
                /// <param name="channel"> </param>
                /// <returns>string</returns>
        public async Task<string> Record(object channel=null)
        {
             var jArgs = new JObject();

             if (channel != null)
             {
                 var jpropchannel = JToken.FromObject(channel, _client.Serializer);
                 jArgs.Add(new JProperty("channel", jpropchannel));
             }
            return await _client.GetData<string>("PVR.Record", jArgs);
        }

                /// <summary>
                /// Starts a channel scan
                /// </summary>
                /// <returns>string</returns>
        public async Task<string> Scan()
        {
            return await _client.GetData<string>("PVR.Scan",null);
        }

                /// <summary>
                /// Creates or deletes a onetime timer or timer rule for a given show. If it exists, it will be deleted. If it does not exist, it will be created
                /// </summary>
                /// <param name="broadcastid"> REQUIRED the broadcast id of the item to toggle a onetime timer or time rule for</param>
                /// <param name="timerrule"> controls whether to create / delete a timer rule or a onetime timer</param>
                /// <returns>string</returns>
        public async Task<string> ToggleTimer(int? broadcastid=null, bool? timerrule=null)
        {
             var jArgs = new JObject();

             if (broadcastid == null)
              {
                 throw new global::System.ArgumentException("Parameter cannot be null broadcastid");
              }
             else
              {
                 var jpropbroadcastid = JToken.FromObject(broadcastid, _client.Serializer);
                 jArgs.Add(new JProperty("broadcastid", jpropbroadcastid));
              }
             if (timerrule != null)
             {
                 var jproptimerrule = JToken.FromObject(timerrule, _client.Serializer);
                 jArgs.Add(new JProperty("timerrule", jproptimerrule));
             }
            return await _client.GetData<string>("PVR.ToggleTimer", jArgs);
        }
   }
}
