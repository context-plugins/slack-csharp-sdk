using System.Text.Json.Serialization;
using Slack.Core.Models;

namespace Slack.Models;

public record Current
{
    [JsonPropertyName("date_started")]
    public required int DateStarted { get; init; }

    [JsonPropertyName("team_id")]
    public required string TeamId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
