using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response of chat.update method
/// </summary>
public record ChatUpdatesuccessschema1
{
    [JsonPropertyName("channel")]
    public required string Channel { get; init; }

    [JsonPropertyName("message")]
    public required Messageobject1 Message { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("text")]
    public required string Text { get; init; }

    [JsonPropertyName("ts")]
    public required string Ts { get; init; }
}
