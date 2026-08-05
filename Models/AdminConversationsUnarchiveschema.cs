using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response of admin.conversations.unarchive
/// </summary>
public record AdminConversationsUnarchiveschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
