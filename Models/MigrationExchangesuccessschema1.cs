using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from migration.exchange method
/// </summary>
public record MigrationExchangesuccessschema1
{
    [JsonPropertyName("enterprise_id")]
    public required string EnterpriseId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invalid_user_ids")]
    public IReadOnlyList<string>? InvalidUserIds { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("team_id")]
    [RegularExpression("^[T][A-Z0-9]{2,}$")]
    public required string TeamId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_id_map")]
    public object? UserIdMap { get; init; }
}
