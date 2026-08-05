using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from usergroups.users.list method
/// </summary>
public record UsergroupsUsersListschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("users")]
    public required IReadOnlyList<string> Users { get; init; }
}
