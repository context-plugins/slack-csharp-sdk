using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for error response api.test method
/// </summary>
public record ApiTesterrorschema1Error
{
    [JsonPropertyName("error")]
    public required string Error { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonExtensionData]
    public AdditionalProperties<object> AdditionalProperties { get; init; } = [];
}
