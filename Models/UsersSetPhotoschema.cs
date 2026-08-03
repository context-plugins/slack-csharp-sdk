using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from users.setPhoto method
/// </summary>
public record UsersSetPhotoschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("profile")]
    public required Profile1 Profile { get; init; }
}
