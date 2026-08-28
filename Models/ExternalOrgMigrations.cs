using System.Collections.Generic;
using System.Text.Json.Serialization;
using Slack.Core.Models;

namespace Slack.Models;

public record ExternalOrgMigrations
{
    [JsonPropertyName("current")]
    public required IReadOnlyList<Current> Current { get; init; }

    [JsonPropertyName("date_updated")]
    public required int DateUpdated { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
