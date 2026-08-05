using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response of chat.postMessage method
/// </summary>
public record ChatPostMessagesuccessschema1
{
    [JsonPropertyName("channel")]
    [RegularExpression("^[CGD][A-Z0-9]{8,}$")]
    public required string Channel { get; init; }

    [JsonPropertyName("message")]
    public required Messageobject Message { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("ts")]
    [RegularExpression("^\\d{10}\\.\\d{6}$")]
    public required string Ts { get; init; }
}
