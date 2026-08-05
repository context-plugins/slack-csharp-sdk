using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from apps.permissions.request method
/// </summary>
public record AppsPermissionsRequestschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
