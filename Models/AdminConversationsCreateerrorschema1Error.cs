using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response from admin.conversations.create
/// </summary>
public record AdminConversationsCreateerrorschema1Error
{
    [JsonPropertyName("error")]
    public required AdminConversationsCreateErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
