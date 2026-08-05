using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from conversations.join method
/// </summary>
public record ConversationsJoinsuccessschema1
{
    [JsonPropertyName("channel")]
    public required object Channel { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response_metadata")]
    public Responsemetadata3? ResponseMetadata { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warning")]
    public string? Warning { get; init; }
}
