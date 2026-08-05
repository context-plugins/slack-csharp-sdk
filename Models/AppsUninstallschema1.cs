using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from apps.uninstall method
/// </summary>
public record AppsUninstallschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
