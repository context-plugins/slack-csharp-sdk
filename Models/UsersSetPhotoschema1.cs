using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from users.setPhoto method
/// </summary>
public record UsersSetPhotoschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("profile")]
    public required Profile1 Profile { get; init; }
}
