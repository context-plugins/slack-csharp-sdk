using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response of admin.conversations.setConversationPrefs
/// </summary>
public record AdminConversationsSetConversationPrefsschema
{
    [JsonPropertyName("ok")]
    public string Ok { get; } = "True";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
