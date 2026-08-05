using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from users.profile.get method
/// </summary>
public record UsersProfileGetschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("profile")]
    public required Userprofileobject Profile { get; init; }
}
