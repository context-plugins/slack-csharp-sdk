using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from conversations.setPurpose method
/// </summary>
public record ConversationsSetPurposesuccessschema
{
    [JsonPropertyName("channel")]
    public required object Channel { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
