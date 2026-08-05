using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for error response api.test method
/// </summary>
public record ApiTesterrorschema1
{
    [JsonPropertyName("error")]
    public required string Error { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
