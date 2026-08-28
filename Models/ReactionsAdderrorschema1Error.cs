using System.Text.Json.Serialization;
using Slack.Core.Models;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response from reactions.add method
/// </summary>
public record ReactionsAdderrorschema1Error
{
    /// <summary>
    /// Note: PHP callstack is only visible in dev/qa
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("callstack")]
    public string? Callstack { get; init; }

    [JsonPropertyName("error")]
    public required ReactionsAddErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
