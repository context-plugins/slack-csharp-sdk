using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response of admin.conversations.rename
/// </summary>
public record AdminConversationsRenameschema1
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
