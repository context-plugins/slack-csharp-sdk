using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;
using SlackWebApi.Core.Validation.Attributes;

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
    public string Ok { get; } = "True";

    [JsonPropertyName("paging")]
    public required Pagingobject Paging { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
