using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from apps.permissions.request method
/// </summary>
public record AppsPermissionsRequestschema
{
    [JsonPropertyName("ok")]
    public string Ok { get; } = "True";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
