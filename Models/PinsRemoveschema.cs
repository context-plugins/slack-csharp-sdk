using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from pins.remove method
/// </summary>
public record PinsRemoveschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
