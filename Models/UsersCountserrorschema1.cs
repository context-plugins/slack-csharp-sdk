using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for error response users.getPresence method
/// </summary>
public record UsersCountserrorschema1
{
    [JsonPropertyName("error")]
    public required string Error { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
