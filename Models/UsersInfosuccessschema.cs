using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from users.info method
/// </summary>
public record UsersInfosuccessschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("user")]
    public required object User { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
