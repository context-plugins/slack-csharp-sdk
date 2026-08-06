using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response of admin.conversations.disconnectShared
/// </summary>
public record AdminConversationsRenameschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
