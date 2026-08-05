using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response from admin.conversations.setConversationPrefs
/// </summary>
public record AdminConversationsSetConversationPrefserrorschema1
{
    [JsonPropertyName("error")]
    public required AdminConversationsSetConversationPrefsErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
