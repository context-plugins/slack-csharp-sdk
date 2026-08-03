using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from reactions.add method
/// </summary>
public record ReactionsAddschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
