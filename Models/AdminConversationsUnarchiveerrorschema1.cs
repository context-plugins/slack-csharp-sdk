using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response from admin.conversations.getConversationPrefs
/// </summary>
public record AdminConversationsUnarchiveerrorschema1
{
    [JsonPropertyName("error")]
    public required AdminConversationsGetConversationPrefsErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
