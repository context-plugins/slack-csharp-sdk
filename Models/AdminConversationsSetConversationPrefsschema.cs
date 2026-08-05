using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response of admin.conversations.setConversationPrefs
/// </summary>
public record AdminConversationsSetConversationPrefsschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
