using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Slack.Core.Models;

namespace Slack.Models;

public record BotProfileObject
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

    [JsonPropertyName("team_id")]
    [RegularExpression("^[T][A-Z0-9]{2,}$")]
    public required string TeamId { get; init; }

    [JsonPropertyName("updated")]
    public required int Updated { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
