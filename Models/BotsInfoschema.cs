using System.Text.Json.Serialization;
using Slack.Core.Models;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from bots.info method
/// </summary>
public record BotsInfoschema
{
    [JsonPropertyName("bot")]
    public required Bot Bot { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
