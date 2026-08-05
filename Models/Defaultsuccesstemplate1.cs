using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// This method either only returns a brief _OK_ response or a verbose schema is not available for this method.
/// </summary>
public record Defaultsuccesstemplate1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
