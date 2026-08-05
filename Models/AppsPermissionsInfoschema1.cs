using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from apps.permissions.info method
/// </summary>
public record AppsPermissionsInfoschema1
{
    [JsonPropertyName("info")]
    public required Info Info { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
