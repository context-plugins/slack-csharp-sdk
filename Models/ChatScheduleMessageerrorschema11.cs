using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response chat.scheduleMessage method
/// </summary>
public record ChatScheduleMessageerrorschema11
{
    /// <summary>
    /// Note: PHP callstack is only visible in dev/qa
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("callstack")]
    public string? Callstack { get; init; }

    [JsonPropertyName("error")]
    public required ChatScheduleMessageErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required Ok Ok { get; init; }
}
