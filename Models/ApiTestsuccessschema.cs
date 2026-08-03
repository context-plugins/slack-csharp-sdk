using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response api.test method
/// </summary>
public record ApiTestsuccessschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
