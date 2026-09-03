using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Models;

public record Team1
{
    [JsonPropertyName("domain")]
    public required string Domain { get; init; }

    [JsonPropertyName("id")]
    [RegularExpression("^[T][A-Z0-9]{2,}$")]
    public required string Id { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
