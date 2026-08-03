using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response api.permissions.scopes.list method
/// </summary>
public record ApiPermissionsScopesListsuccessschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("scopes")]
    public required Scopes Scopes { get; init; }
}
