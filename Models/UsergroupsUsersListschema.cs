using System.Collections.Generic;
using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from usergroups.users.list method
/// </summary>
public record UsergroupsUsersListschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("users")]
    public required IReadOnlyList<string> Users { get; init; }
}
