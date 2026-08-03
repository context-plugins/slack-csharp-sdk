using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from apps.permissions.info method
/// </summary>
public record AppsPermissionsInfoschema
{
    [JsonPropertyName("info")]
    public required Info Info { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
