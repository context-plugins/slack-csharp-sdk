using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from reminders.delete method
/// </summary>
public record RemindersDeleteschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
