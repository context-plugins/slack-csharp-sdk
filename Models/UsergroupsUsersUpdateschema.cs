using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from usergroups.users.update method
/// </summary>
public record UsergroupsUsersUpdateschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("usergroup")]
    public required SubteamUsergroupObject Usergroup { get; init; }
}
