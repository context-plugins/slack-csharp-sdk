using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from chat.deleteScheduledMessage method
/// </summary>
public record ChatDeleteScheduledMessageschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
