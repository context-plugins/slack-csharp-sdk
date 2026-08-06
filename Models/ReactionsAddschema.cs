using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from reactions.add method
/// </summary>
public record ReactionsAddschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
