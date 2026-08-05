using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from stars.remove method
/// </summary>
public record StarsRemoveschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
