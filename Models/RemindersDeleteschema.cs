using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from reminders.delete method
/// </summary>
public record RemindersDeleteschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
