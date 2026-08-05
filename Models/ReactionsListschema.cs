using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from reactions.list method
/// </summary>
public record ReactionsListschema
{
    [JsonPropertyName("items")]
    public required IReadOnlyList<object> Items { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paging")]
    public Pagingobject? Paging { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response_metadata")]
    public object? ResponseMetadata { get; init; }
}
