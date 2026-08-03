using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for error response from admin.conversations.convertToPrivate
/// </summary>
public record AdminConversationsConvertToPrivateerrorschema1
{
    [JsonPropertyName("error")]
    public required AdminConversationsConvertToPrivateErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required Ok Ok { get; init; }
}
