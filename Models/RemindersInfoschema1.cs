using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from reminders.info method
/// </summary>
public record RemindersInfoschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("reminder")]
    public required ObjsReminder Reminder { get; init; }
}
