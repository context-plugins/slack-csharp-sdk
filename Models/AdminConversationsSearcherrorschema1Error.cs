using System.Text.Json.Serialization;
using Slack.Core.Models;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response from admin.conversations.search
/// </summary>
public record AdminConversationsSearcherrorschema1Error
{
    [JsonPropertyName("error")]
    public required AdminConversationsSearchErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
