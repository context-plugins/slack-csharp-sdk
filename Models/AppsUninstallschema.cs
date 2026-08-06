using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from apps.uninstall method
/// </summary>
public record AppsUninstallschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
