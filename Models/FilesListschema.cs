using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Validation.Attributes;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from files.list method
/// </summary>
public record FilesListschema
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
