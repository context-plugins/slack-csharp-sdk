using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Models;

public record Bot
{
    [JsonPropertyName("app_id")]
    [RegularExpression("^A[A-Z0-9]{1,}$")]
    public required string AppId { get; init; }

    [JsonPropertyName("deleted")]
    public required bool Deleted { get; init; }

    [JsonPropertyName("icons")]
    public required Icons Icons { get; init; }

    [JsonPropertyName("id")]
    [RegularExpression("^B[A-Z0-9]{8,}$")]
    public required string Id { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("updated")]
    public required int Updated { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_id")]
    [RegularExpression("^[UW][A-Z0-9]{2,}$")]
    public string? UserId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
