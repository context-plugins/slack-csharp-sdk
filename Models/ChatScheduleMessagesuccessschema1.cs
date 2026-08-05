using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response of chat.scheduleMessage method
/// </summary>
public record ChatScheduleMessagesuccessschema1
{
    [JsonPropertyName("channel")]
    [RegularExpression("^[CGD][A-Z0-9]{8,}$")]
    public required string Channel { get; init; }

    [JsonPropertyName("message")]
    public required Message Message { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("post_at")]
    public required int PostAt { get; init; }

    [JsonPropertyName("scheduled_message_id")]
    [RegularExpression("^[Q][A-Z0-9]{8,}$")]
    public required string ScheduledMessageId { get; init; }
}
