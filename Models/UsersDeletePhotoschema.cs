using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from users.deletePhoto method
/// </summary>
public record UsersDeletePhotoschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
