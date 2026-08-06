using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from usergroups.create method
/// </summary>
public record UsergroupsCreateschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("usergroup")]
    public required SubteamUsergroupObject Usergroup { get; init; }
}
