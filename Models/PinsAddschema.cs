using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from pins.add method
/// </summary>
public record PinsAddschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
