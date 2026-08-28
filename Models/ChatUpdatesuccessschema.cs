using System.Text.Json.Serialization;
using Slack.Core.Models;

namespace Slack.Models;

/// <summary>
/// Schema for successful response of chat.update method
/// </summary>
public record ChatUpdatesuccessschema
{
    [JsonPropertyName("channel")]
    public required string Channel { get; init; }

    [JsonPropertyName("message")]
    public required Messageobject1 Message { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("text")]
    public required string Text { get; init; }

    [JsonPropertyName("ts")]
    public required string Ts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
