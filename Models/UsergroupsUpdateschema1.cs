using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from usergroups.update method
/// </summary>
public record UsergroupsUpdateschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("usergroup")]
    public required SubteamUsergroupObject Usergroup { get; init; }
}
