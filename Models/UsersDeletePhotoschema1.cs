using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from users.deletePhoto method
/// </summary>
public record UsersDeletePhotoschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
