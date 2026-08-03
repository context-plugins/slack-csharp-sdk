using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

public record ResponseMetadata
{
    [JsonPropertyName("next_cursor")]
    public required string NextCursor { get; init; }
}
