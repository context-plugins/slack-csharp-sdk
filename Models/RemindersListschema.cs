using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from reminders.list method
/// </summary>
public record RemindersListschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("reminders")]
    public required IReadOnlyList<ObjsReminder> Reminders { get; init; }
}
