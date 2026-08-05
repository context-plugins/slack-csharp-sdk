using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from users.lookupByEmail method
/// </summary>
public record UsersLookupByEmailsuccessschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("user")]
    public required object User { get; init; }
}
