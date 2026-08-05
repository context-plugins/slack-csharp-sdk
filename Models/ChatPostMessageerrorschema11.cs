using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response chat.postMessage method
/// </summary>
public record ChatPostMessageerrorschema11
{
    /// <summary>
    /// Note: PHP callstack is only visible in dev/qa
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("callstack")]
    public string? Callstack { get; init; }

    [JsonPropertyName("error")]
    public required ChatPostMessageErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required Ok Ok { get; init; }
}
