using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Slack.Models;

public record ExternalOrgMigrations
{
    [JsonPropertyName("current")]
    public required IReadOnlyList<Current> Current { get; init; }

    [JsonPropertyName("date_updated")]
    public required int DateUpdated { get; init; }
}
