using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response from admin.conversations.disconnectShared
/// </summary>
public record AdminConversationsDisconnectSharederrorschema11
{
    [JsonPropertyName("error")]
    public required AdminConversationsDisconnectSharedErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required Ok Ok { get; init; }
}
