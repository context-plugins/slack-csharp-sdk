using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from chat.deleteScheduledMessage method
/// </summary>
public record ChatDeleteScheduledMessageschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
