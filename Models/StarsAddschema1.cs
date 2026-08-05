using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from stars.add method
/// </summary>
public record StarsAddschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
