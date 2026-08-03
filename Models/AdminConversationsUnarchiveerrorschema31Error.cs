using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for error response from admin.conversations.unarchive
/// </summary>
public record AdminConversationsUnarchiveerrorschema31Error
{
    [JsonPropertyName("error")]
    public required AdminConversationsUnarchiveErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required Ok Ok { get; init; }
}
