using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response api.test method
/// </summary>
public record ApiTestsuccessschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
