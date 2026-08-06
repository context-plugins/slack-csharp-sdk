using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

public record ResourcesininfofromappsPermissionsInfo
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("excluded_ids")]
    public IReadOnlyList<object>? ExcludedIds { get; init; }

    [JsonPropertyName("ids")]
    public required IReadOnlyList<object> Ids { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wildcard")]
    public bool? Wildcard { get; init; }
}
