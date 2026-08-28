using System.Text.Json.Serialization;
using Slack.Core.Models;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from team.info method
/// </summary>
public record TeamInfoschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("team")]
    public required TeamObject Team { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
