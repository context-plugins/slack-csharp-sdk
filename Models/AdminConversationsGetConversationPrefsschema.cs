using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response of admin.conversations.getConversationPrefs
/// </summary>
public record AdminConversationsGetConversationPrefsschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prefs")]
    public Prefs1? Prefs { get; init; }
}
