using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Slack.Core.Validation.Attributes;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from team.integrationLogs method
/// </summary>
public record TeamIntegrationLogsschema1
{
    [JsonPropertyName("logs")]
    [MinLength(1)]
    [UniqueItems]
    public required IReadOnlyList<Log> Logs { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("paging")]
    public required Pagingobject Paging { get; init; }
}
