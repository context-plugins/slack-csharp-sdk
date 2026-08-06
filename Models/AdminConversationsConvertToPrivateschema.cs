using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response of admin.conversations.convertToPrivate
/// </summary>
public record AdminConversationsConvertToPrivateschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
