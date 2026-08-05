using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response conversations.kick method
/// </summary>
public record ConversationsKicksuccessschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
