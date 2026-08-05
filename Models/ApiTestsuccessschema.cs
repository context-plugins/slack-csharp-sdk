using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response api.test method
/// </summary>
public record ApiTestsuccessschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
