using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from apps.permissions.info method
/// </summary>
public record AppsPermissionsInfoschema
{
    [JsonPropertyName("info")]
    public required Info Info { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
