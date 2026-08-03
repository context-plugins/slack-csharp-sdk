using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from team.profile.get method
/// </summary>
public record TeamProfileGetsuccessschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("profile")]
    public required Profile Profile { get; init; }
}
