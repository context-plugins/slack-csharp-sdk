using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from bots.info method
/// </summary>
public record BotsInfoschema1
{
    [JsonPropertyName("bot")]
    public required Bot Bot { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
