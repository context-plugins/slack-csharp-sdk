using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from stars.add method
/// </summary>
public record StarsAddschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
