using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Slack.Core.Validation.Attributes;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from users.list method
/// </summary>
public record UsersListschema
{
    [JsonPropertyName("cache_ts")]
    public required int CacheTs { get; init; }

    [JsonPropertyName("members")]
    [MinLength(1)]
    [UniqueItems]
    public required IReadOnlyList<object> Members { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response_metadata")]
    public object? ResponseMetadata { get; init; }
}
