using System.Collections.Generic;
using System.Text.Json.Serialization;
using Slack.Core.Models;

namespace Slack.Models;

public record Team
{
    [JsonPropertyName("resources")]
    public required ResourcesininfofromappsPermissionsInfo Resources { get; init; }

    [JsonPropertyName("scopes")]
    public required IReadOnlyList<string> Scopes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
