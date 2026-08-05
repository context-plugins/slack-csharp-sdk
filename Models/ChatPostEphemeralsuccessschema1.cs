using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from chat.postEphemeral method
/// </summary>
public record ChatPostEphemeralsuccessschema1
{
    [JsonPropertyName("message_ts")]
    [RegularExpression("^\\d{10}\\.\\d{6}$")]
    public required string MessageTs { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
