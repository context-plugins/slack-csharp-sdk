using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from users.setPhoto method
/// </summary>
public record UsersSetPhotoschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("profile")]
    public required Profile1 Profile { get; init; }
}
