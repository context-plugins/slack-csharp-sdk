using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response of admin.conversations.getConversationPrefs
/// </summary>
public record AdminConversationsGetConversationPrefsschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prefs")]
    public Prefs1? Prefs { get; init; }
}
