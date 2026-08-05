using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response api.test method
/// </summary>
public record ApiTesterrorschema1Error1
{
    [JsonPropertyName("error")]
    public required string Error { get; init; }

    [JsonPropertyName("ok")]
    public required Ok Ok { get; init; }
}
