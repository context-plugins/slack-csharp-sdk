using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response conversations.mark method
/// </summary>
public record ConversationsMarksuccessschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
