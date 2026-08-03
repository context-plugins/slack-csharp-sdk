using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from reminders.complete method
/// </summary>
public record RemindersCompleteschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
