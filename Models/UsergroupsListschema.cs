using System.Collections.Generic;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from usergroups.list method
/// </summary>
public record UsergroupsListschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("usergroups")]
    public required IReadOnlyList<SubteamUsergroupObject> Usergroups { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
