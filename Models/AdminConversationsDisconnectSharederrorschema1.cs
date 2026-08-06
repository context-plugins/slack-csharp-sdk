using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for error response from admin.conversations.disconnectShared
/// </summary>
public record AdminConversationsDisconnectSharederrorschema1
{
    [JsonPropertyName("error")]
    public required AdminConversationsDisconnectSharedErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
