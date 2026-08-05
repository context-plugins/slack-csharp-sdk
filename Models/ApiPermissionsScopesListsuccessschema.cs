using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response api.permissions.scopes.list method
/// </summary>
public record ApiPermissionsScopesListsuccessschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("scopes")]
    public required Scopes Scopes { get; init; }
}
