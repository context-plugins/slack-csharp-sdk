using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response auth.test method
/// </summary>
public record AuthTesterrorschema1
{
    /// <summary>
    /// Note: PHP callstack is only visible in dev/qa
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("callstack")]
    public string? Callstack { get; init; }

    [JsonPropertyName("error")]
    public required AuthTestErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
