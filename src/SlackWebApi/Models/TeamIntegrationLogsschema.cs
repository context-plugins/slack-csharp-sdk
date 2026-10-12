using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;
using SlackWebApi.Core.Validation.Attributes;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from team.integrationLogs method
/// </summary>
public record TeamIntegrationLogsschema
{
    [JsonPropertyName("logs")]
    [MinLength(1)]
    [UniqueItems]
    public required IReadOnlyList<Log> Logs { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("paging")]
    public required Pagingobject Paging { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
