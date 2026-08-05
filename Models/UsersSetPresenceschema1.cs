using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from users.setPresence method
/// </summary>
public record UsersSetPresenceschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
