using System;
using Newtonsoft.Json;

namespace RealTimeChatApp.Models
{
    public class ConversationOverview
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Image")]
        public string Image { get; set; }

        [JsonProperty("MembersCount")]
        public int MembersCount { get; set; }

        [JsonProperty("LastMessage")]
        public string LastMessage { get; set; }

        [JsonProperty("LastMessageDate")]
        public string LastMessageDate { get; set; }

        [JsonProperty("UnreadMessagesCount")]
        public int UnreadMessagesCount { get; set; }
    }
}