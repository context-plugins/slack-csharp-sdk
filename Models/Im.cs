using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Slack.Models;

public record Im
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resources")]
    public ResourcesininfofromappsPermissionsInfo? Resources { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scopes")]
    public IReadOnlyList<string>? Scopes { get; init; }
}
