using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from reminders.add method
/// </summary>
public record RemindersAddschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("reminder")]
    public required ObjsReminder Reminder { get; init; }
}
