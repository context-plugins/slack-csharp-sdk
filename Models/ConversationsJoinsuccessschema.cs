using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from conversations.join method
/// </summary>
public record ConversationsJoinsuccessschema
{
    [JsonPropertyName("channel")]
    public required object Channel { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response_metadata")]
    public Responsemetadata3? ResponseMetadata { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warning")]
    public string? Warning { get; init; }
}
