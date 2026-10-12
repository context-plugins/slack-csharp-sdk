using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from chat.postEphemeral method
/// </summary>
public record ChatPostEphemeralsuccessschema
{
    [JsonPropertyName("message_ts")]
    [RegularExpression("^\\d{10}\\.\\d{6}$")]
    public required string MessageTs { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
