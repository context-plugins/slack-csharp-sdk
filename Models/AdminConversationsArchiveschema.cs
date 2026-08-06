using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response of admin.conversations.archive
/// </summary>
public record AdminConversationsArchiveschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
