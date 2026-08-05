using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from files.info method
/// </summary>
public record FilesInfoschema1
{
    [JsonPropertyName("comments")]
    public required IReadOnlyList<object> Comments { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("content_html")]
    public string? ContentHtml { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("editor")]
    [RegularExpression("^[UW][A-Z0-9]{2,}$")]
    public string? Editor { get; init; }

    [JsonPropertyName("file")]
    public required Fileobject File { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paging")]
    public Pagingobject? Paging { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response_metadata")]
    public object? ResponseMetadata { get; init; }
}
