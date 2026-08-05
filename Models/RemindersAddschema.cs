using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from reminders.add method
/// </summary>
public record RemindersAddschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("reminder")]
    public required ObjsReminder Reminder { get; init; }
}
