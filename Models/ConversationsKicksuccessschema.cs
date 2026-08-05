using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response conversations.kick method
/// </summary>
public record ConversationsKicksuccessschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
