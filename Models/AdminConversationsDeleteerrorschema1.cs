using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for error response from admin.conversations.delete
/// </summary>
public record AdminConversationsDeleteerrorschema1
{
    [JsonPropertyName("error")]
    public required AdminConversationsDeleteErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
