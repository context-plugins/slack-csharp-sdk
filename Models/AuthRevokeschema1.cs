using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from auth.revoke method
/// </summary>
public record AuthRevokeschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("revoked")]
    public required bool Revoked { get; init; }
}
