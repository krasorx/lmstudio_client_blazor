using System.Text.Json.Serialization;

namespace lmstudio_client.Client
{
    public class Agent_response
    {
        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }
    }

    public class LmStudioResponse
    {
        [JsonPropertyName("choices")]
        public List<LmStudioChoice> Choices { get; set; }
    }

    public class LmStudioChoice
    {
        [JsonPropertyName("message")]
        public LmStudioMessage Message { get; set; }
    }

    public class LmStudioMessage
    {
        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}
