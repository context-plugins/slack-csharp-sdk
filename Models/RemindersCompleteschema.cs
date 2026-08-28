using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from reminders.complete method
/// </summary>
public record RemindersCompleteschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
