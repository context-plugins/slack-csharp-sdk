using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response from users.info method
/// </summary>
public record UsersInfoerrorschema1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("callstack")]
    public string? Callstack { get; init; }

    [JsonPropertyName("error")]
    public required UsersInfoErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
