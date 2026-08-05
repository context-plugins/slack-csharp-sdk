using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from reactions.add method
/// </summary>
public record ReactionsAddschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
