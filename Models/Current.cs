using System.Text.Json.Serialization;

namespace Slack.Models;

public record Current
{
    [JsonPropertyName("date_started")]
    public required int DateStarted { get; init; }

    [JsonPropertyName("team_id")]
    public required string TeamId { get; init; }
}
