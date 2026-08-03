using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from users.lookupByEmail method
/// </summary>
public record UsersLookupByEmailsuccessschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("user")]
    public required object User { get; init; }
}
