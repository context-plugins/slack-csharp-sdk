using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

public record BlockKitblock
{
    [JsonPropertyName("type")]
    public required string Type { get; init; }
}
