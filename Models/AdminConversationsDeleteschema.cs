using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response of admin.conversations.delete
/// </summary>
public record AdminConversationsDeleteschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
