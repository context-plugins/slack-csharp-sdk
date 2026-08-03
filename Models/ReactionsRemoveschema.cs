using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from reactions.remove method
/// </summary>
public record ReactionsRemoveschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
