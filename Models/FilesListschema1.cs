using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Slack.Core.Validation.Attributes;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from files.list method
/// </summary>
public record FilesListschema1
{
    [JsonPropertyName("files")]
    [MinLength(0)]
    [UniqueItems]
    public required IReadOnlyList<Fileobject> Files { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("paging")]
    public required Pagingobject Paging { get; init; }
}
