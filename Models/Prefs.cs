using System.Collections.Generic;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Models;

public record Prefs
{
    [JsonPropertyName("channels")]
    public required IReadOnlyList<string> Channels { get; init; }

    [JsonPropertyName("groups")]
    public required IReadOnlyList<string> Groups { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
