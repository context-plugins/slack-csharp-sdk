using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from users.setPresence method
/// </summary>
public record UsersSetPresenceschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
