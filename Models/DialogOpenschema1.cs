using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from dialog.open method
/// </summary>
public record DialogOpenschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
