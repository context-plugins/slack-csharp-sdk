using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for error response from admin.conversations.archive
/// </summary>
public record AdminConversationsArchiveerrorschema1Error
{
    [JsonPropertyName("error")]
    public required AdminConversationsArchiveErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required Ok Ok { get; init; }
}
