using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response api.test method
/// </summary>
public record ApiTestsuccessschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonExtensionData]
    public AdditionalProperties<object> AdditionalProperties { get; init; } = [];
}
