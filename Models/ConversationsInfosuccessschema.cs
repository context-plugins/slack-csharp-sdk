using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response conversations.info
/// </summary>
public record ConversationsInfosuccessschema
{
    [JsonPropertyName("channel")]
    public required object Channel { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
