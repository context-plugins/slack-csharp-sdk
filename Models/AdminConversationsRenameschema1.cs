using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response of admin.conversations.rename
/// </summary>
public record AdminConversationsRenameschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
