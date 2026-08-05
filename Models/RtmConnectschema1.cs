using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from rtm.connect method
/// </summary>
public record RtmConnectschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("self")]
    public required Self Self { get; init; }

    [JsonPropertyName("team")]
    public required Team1 Team { get; init; }

    [JsonPropertyName("url")]
    public required string Url { get; init; }
}
