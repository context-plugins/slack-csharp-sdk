using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from usergroups.enable method
/// </summary>
public record UsergroupsEnableschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("usergroup")]
    public required SubteamUsergroupObject Usergroup { get; init; }
}
