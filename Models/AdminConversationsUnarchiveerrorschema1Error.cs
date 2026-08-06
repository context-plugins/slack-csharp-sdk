using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for error response from admin.conversations.getConversationPrefs
/// </summary>
public record AdminConversationsUnarchiveerrorschema1Error
{
    [JsonPropertyName("error")]
    public required AdminConversationsGetConversationPrefsErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
