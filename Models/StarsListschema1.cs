using System.Collections.Generic;
using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from stars.list method
/// </summary>
public record StarsListschema1
{
    [JsonPropertyName("items")]
    public required IReadOnlyList<object> Items { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paging")]
    public Pagingobject? Paging { get; init; }
}
