using System.Collections.Generic;
using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from usergroups.list method
/// </summary>
public record UsergroupsListschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("usergroups")]
    public required IReadOnlyList<SubteamUsergroupObject> Usergroups { get; init; }
}
