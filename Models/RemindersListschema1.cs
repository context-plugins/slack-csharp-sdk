using System.Collections.Generic;
using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from reminders.list method
/// </summary>
public record RemindersListschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("reminders")]
    public required IReadOnlyList<ObjsReminder> Reminders { get; init; }
}
