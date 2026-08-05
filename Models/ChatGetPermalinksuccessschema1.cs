using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response chat.getPermalink
/// </summary>
public record ChatGetPermalinksuccessschema1
{
    [JsonPropertyName("channel")]
    [RegularExpression("^[CGD][A-Z0-9]{8,}$")]
    public required string Channel { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("permalink")]
    public required string Permalink { get; init; }
}
