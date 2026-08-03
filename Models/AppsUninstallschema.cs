using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from apps.uninstall method
/// </summary>
public record AppsUninstallschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
