using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from reminders.info method
/// </summary>
public record RemindersInfoschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("reminder")]
    public required ObjsReminder Reminder { get; init; }
}
