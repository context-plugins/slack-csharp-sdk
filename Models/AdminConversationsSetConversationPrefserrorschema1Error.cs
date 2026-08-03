using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for error response from admin.conversations.setConversationPrefs
/// </summary>
public record AdminConversationsSetConversationPrefserrorschema1Error
{
    [JsonPropertyName("error")]
    public required AdminConversationsSetConversationPrefsErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required Ok Ok { get; init; }
}
