using System.Text.Json.Serialization;
using Slack.Core.Models;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response from files.revokePublicURL method
/// </summary>
public record FilesRevokePublicUrLerrorschema1
{
    /// <summary>
    /// Note: PHP callstack is only visible in dev/qa
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("callstack")]
    public string? Callstack { get; init; }

    [JsonPropertyName("error")]
    public required FilesRevokePublicUrlErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
