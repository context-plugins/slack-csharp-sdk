using System.Text.Json.Serialization;

namespace Slack.Models;

public record BlockKitblock
{
    [JsonPropertyName("type")]
    public required string Type { get; init; }
}
