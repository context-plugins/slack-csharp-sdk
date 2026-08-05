using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response of admin.conversations.delete
/// </summary>
public record AdminConversationsDeleteschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
