using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from pins.remove method
/// </summary>
public record PinsRemoveschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
