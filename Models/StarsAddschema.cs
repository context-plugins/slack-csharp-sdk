using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from stars.add method
/// </summary>
public record StarsAddschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
