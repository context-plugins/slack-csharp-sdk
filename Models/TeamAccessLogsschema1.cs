using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Slack.Core.Validation.Attributes;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from team.accessLogs method
/// </summary>
public record TeamAccessLogsschema1
{
    [JsonPropertyName("logins")]
    [MinLength(1)]
    [UniqueItems]
    public required IReadOnlyList<Login> Logins { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("paging")]
    public required Pagingobject Paging { get; init; }
}
