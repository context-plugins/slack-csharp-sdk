using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Slack.Models;

public record Prefs
{
    [JsonPropertyName("channels")]
    public required IReadOnlyList<string> Channels { get; init; }

    [JsonPropertyName("groups")]
    public required IReadOnlyList<string> Groups { get; init; }
}
