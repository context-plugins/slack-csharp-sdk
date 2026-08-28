using System.Text.Json.Serialization;
using Slack.Core.Models;

namespace Slack.Models;

public record ResponseMetadata
{
    [JsonPropertyName("next_cursor")]
    public required string NextCursor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
