using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from chat.deleteScheduledMessage method
/// </summary>
public record ChatDeleteScheduledMessageschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
