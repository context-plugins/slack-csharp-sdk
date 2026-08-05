using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response from admin.conversations.invite
/// </summary>
public record AdminConversationsInviteerrorschema11
{
    [JsonPropertyName("error")]
    public required AdminConversationsInviteErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required Ok Ok { get; init; }
}
