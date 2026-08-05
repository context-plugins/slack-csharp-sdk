using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from users.profile.get method
/// </summary>
public record UsersProfileGetschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("profile")]
    public required Userprofileobject Profile { get; init; }
}
