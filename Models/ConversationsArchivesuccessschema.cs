using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response conversations.archive method
/// </summary>
public record ConversationsArchivesuccessschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
