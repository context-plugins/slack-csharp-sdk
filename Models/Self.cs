using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

public record Self
{
    [JsonPropertyName("id")]
    [RegularExpression("^[UW][A-Z0-9]{2,}$")]
    public required string Id { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }
}
