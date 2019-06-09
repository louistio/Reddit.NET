﻿using Newtonsoft.Json;
using Reddit.Models.Converters;
using System;

namespace Reddit.Things
{
    [Serializable]
    public class ModmailSubreddit
    {
        [JsonProperty("display_name")]
        public string DisplayName;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("lastUpdated")]
        [JsonConverter(typeof(UtcTimestampConverter))]
        public DateTime LastUpdated;

        [JsonProperty("keyColor")]
        public string KeyColor;

        [JsonProperty("subscribers")]
        public int Subscribers;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("icon")]
        public string Icon;
    }
}
