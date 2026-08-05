using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response from admin.conversations.search
/// </summary>
public record AdminConversationsSearcherrorschema1
{
    [JsonPropertyName("error")]
    public required AdminConversationsSearchErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
