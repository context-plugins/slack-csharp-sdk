using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for error response from admin.conversations.create
/// </summary>
public record AdminConversationsCreateerrorschema1Error
{
    [JsonPropertyName("error")]
    public required AdminConversationsCreateErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required Ok Ok { get; init; }
}
