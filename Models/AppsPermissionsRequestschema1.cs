using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from apps.permissions.request method
/// </summary>
public record AppsPermissionsRequestschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
