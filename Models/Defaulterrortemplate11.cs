using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// This method either only returns a brief _not OK_ response or a verbose schema is not available for this method.
/// </summary>
public record Defaulterrortemplate11
{
    [JsonPropertyName("ok")]
    public required Ok Ok { get; init; }
}
