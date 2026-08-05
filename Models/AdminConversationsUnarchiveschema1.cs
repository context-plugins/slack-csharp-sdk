using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response of admin.conversations.unarchive
/// </summary>
public record AdminConversationsUnarchiveschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
