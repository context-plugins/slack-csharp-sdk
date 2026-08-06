using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

public record Group
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resources")]
    public ResourcesininfofromappsPermissionsInfo? Resources { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scopes")]
    public IReadOnlyList<string>? Scopes { get; init; }
}
