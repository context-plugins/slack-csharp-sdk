using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response from admin.conversations.unarchive
/// </summary>
public record AdminConversationsUnarchiveerrorschema311
{
    [JsonPropertyName("error")]
    public required AdminConversationsUnarchiveErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required Ok Ok { get; init; }
}
