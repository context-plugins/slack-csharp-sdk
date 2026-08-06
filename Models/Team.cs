using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

public record Team
{
    [JsonPropertyName("resources")]
    public required ResourcesininfofromappsPermissionsInfo Resources { get; init; }

    [JsonPropertyName("scopes")]
    public required IReadOnlyList<string> Scopes { get; init; }
}
