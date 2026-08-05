using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response api.permissions.scopes.list method
/// </summary>
public record ApiPermissionsScopesListsuccessschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("scopes")]
    public required Scopes Scopes { get; init; }
}
