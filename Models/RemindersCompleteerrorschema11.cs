using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response from reminders.complete method
/// </summary>
public record RemindersCompleteerrorschema11
{
    /// <summary>
    /// Note: PHP callstack is only visible in dev/qa
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("callstack")]
    public string? Callstack { get; init; }

    [JsonPropertyName("error")]
    public required RemindersCompleteErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required Ok Ok { get; init; }
}
