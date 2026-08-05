using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response from admin.conversations.create
/// </summary>
public record AdminConversationsCreateerrorschema11
{
    [JsonPropertyName("error")]
    public required AdminConversationsCreateErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required Ok Ok { get; init; }
}
