using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from rtm.connect method
/// </summary>
public record RtmConnectschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("self")]
    public required Self Self { get; init; }

    [JsonPropertyName("team")]
    public required Team1 Team { get; init; }

    [JsonPropertyName("url")]
    public required string Url { get; init; }
}
