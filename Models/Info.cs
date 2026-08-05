using System.Text.Json.Serialization;

namespace Slack.Models;

public record Info
{
    [JsonPropertyName("app_home")]
    public required AppHome AppHome { get; init; }

    [JsonPropertyName("channel")]
    public required Channel Channel { get; init; }

    [JsonPropertyName("group")]
    public required Group Group { get; init; }

    [JsonPropertyName("im")]
    public required Im Im { get; init; }

    [JsonPropertyName("mpim")]
    public required Mpim Mpim { get; init; }

    [JsonPropertyName("team")]
    public required Team Team { get; init; }
}
