using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Models;

/// <summary>
/// Generated from users.getPresence with shasum e7251aec575d8863f9e0eb38663ae9dc26655f65
/// </summary>
public record ApImethodusersGetPresence
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auto_away")]
    public bool? AutoAway { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("connection_count")]
    public int? ConnectionCount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_activity")]
    public int? LastActivity { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("manual_away")]
    public bool? ManualAway { get; init; }

    [JsonPropertyName("ok")]
    public string Ok { get; } = "True";

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("online")]
    public bool? Online { get; init; }

    [JsonPropertyName("presence")]
    public required string Presence { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
