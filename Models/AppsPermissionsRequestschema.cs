using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from apps.permissions.request method
/// </summary>
public record AppsPermissionsRequestschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
