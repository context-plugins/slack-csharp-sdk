using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response users.getPresence method
/// </summary>
public record UsersCountserrorschema11
{
    [JsonPropertyName("error")]
    public required string Error { get; init; }

    [JsonPropertyName("ok")]
    public required Ok Ok { get; init; }
}
