using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response from admin.conversations.rename
/// </summary>
public record AdminConversationsUnarchiveerrorschema21
{
    [JsonPropertyName("error")]
    public required AdminConversationsRenameErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
