using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for error response from conversations.leave method
/// </summary>
public record ConversationsLeaveerrorschema1Error
{
    /// <summary>
    /// Note: PHP callstack is only visible in dev/qa
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("callstack")]
    public string? Callstack { get; init; }

    [JsonPropertyName("error")]
    public required ConversationsLeaveErrorEnum Error { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("needed")]
    public string? Needed { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("provided")]
    public string? Provided { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
