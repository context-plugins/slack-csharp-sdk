using System.Collections.Generic;
using System.Text.Json.Serialization;
using Slack.Core.Models;

namespace Slack.Models;

public record CanThread
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public IReadOnlyList<string>? Type { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user")]
    public IReadOnlyList<string>? User { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
