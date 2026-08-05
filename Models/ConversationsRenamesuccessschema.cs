using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from conversations.rename method
/// </summary>
public record ConversationsRenamesuccessschema
{
    [JsonPropertyName("channel")]
    public required object Channel { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
