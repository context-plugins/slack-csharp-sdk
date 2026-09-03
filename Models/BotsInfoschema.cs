using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from bots.info method
/// </summary>
public record BotsInfoschema
{
    [JsonPropertyName("bot")]
    public required Bot Bot { get; init; }

    [JsonPropertyName("ok")]
    public string Ok { get; } = "True";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
