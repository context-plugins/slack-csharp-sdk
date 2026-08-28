using System.Text.Json.Serialization;
using Slack.Core.Models;

namespace Slack.Models;

public record Prefs1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_thread")]
    public CanThread? CanThread { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("who_can_post")]
    public WhoCanPost? WhoCanPost { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
