using System.Text.Json.Serialization;
using Slack.Core.Models;

namespace Slack.Models;

public record BlockKitblock
{
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
