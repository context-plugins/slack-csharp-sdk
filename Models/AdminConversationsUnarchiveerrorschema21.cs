using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

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
