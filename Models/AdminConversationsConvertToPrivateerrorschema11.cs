using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response from admin.conversations.convertToPrivate
/// </summary>
public record AdminConversationsConvertToPrivateerrorschema11
{
    [JsonPropertyName("error")]
    public required AdminConversationsConvertToPrivateErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required Ok Ok { get; init; }
}
