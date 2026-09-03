using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for error response from admin.conversations.getConversationPrefs
/// </summary>
public record AdminConversationsUnarchiveerrorschema1
{
    [JsonPropertyName("error")]
    public required AdminConversationsGetConversationPrefsErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public string Ok { get; } = "False";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
