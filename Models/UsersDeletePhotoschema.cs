using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from users.deletePhoto method
/// </summary>
public record UsersDeletePhotoschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
