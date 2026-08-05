using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from team.profile.get method
/// </summary>
public record TeamProfileGetsuccessschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("profile")]
    public required Profile Profile { get; init; }
}
