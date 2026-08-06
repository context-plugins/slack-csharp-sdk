using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from users.setActive method
/// </summary>
public record UsersSetActiveschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
