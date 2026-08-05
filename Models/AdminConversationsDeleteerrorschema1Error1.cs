using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response from admin.conversations.delete
/// </summary>
public record AdminConversationsDeleteerrorschema1Error1
{
    [JsonPropertyName("error")]
    public required AdminConversationsDeleteErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required Ok Ok { get; init; }
}
