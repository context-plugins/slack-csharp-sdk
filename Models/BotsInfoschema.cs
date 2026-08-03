using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from bots.info method
/// </summary>
public record BotsInfoschema
{
    [JsonPropertyName("bot")]
    public required Bot Bot { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
