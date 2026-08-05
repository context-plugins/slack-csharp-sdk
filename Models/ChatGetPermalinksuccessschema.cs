using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response chat.getPermalink
/// </summary>
public record ChatGetPermalinksuccessschema
{
    [JsonPropertyName("channel")]
    [RegularExpression("^[CGD][A-Z0-9]{8,}$")]
    public required string Channel { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("permalink")]
    public required string Permalink { get; init; }
}
