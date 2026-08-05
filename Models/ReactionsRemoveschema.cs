using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from reactions.remove method
/// </summary>
public record ReactionsRemoveschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
