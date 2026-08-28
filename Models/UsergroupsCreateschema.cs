using System.Text.Json.Serialization;
using Slack.Core.Models;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from usergroups.create method
/// </summary>
public record UsergroupsCreateschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("usergroup")]
    public required SubteamUsergroupObject Usergroup { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
