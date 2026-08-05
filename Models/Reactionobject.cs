using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Slack.Models;

public record Reactionobject
{
    [JsonPropertyName("count")]
    public required int Count { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("users")]
    public required IReadOnlyList<string> Users { get; init; }
}
