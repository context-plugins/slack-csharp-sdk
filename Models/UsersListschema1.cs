using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Slack.Core.Validation.Attributes;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from users.list method
/// </summary>
public record UsersListschema1
{
    [JsonPropertyName("cache_ts")]
    public required int CacheTs { get; init; }

    [JsonPropertyName("members")]
    [MinLength(1)]
    [UniqueItems]
    public required IReadOnlyList<object> Members { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response_metadata")]
    public object? ResponseMetadata { get; init; }
}
