using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response from admin.conversations.archive
/// </summary>
public record AdminConversationsArchiveerrorschema11
{
    [JsonPropertyName("error")]
    public required AdminConversationsArchiveErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required Ok Ok { get; init; }
}
