using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from users.setPresence method
/// </summary>
public record UsersSetPresenceschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
