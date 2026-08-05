using System.Text.Json.Serialization;

namespace Slack.Models;

public record ResponseMetadata
{
    [JsonPropertyName("next_cursor")]
    public required string NextCursor { get; init; }
}
