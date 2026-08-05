using System.Collections.Generic;
using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from chat.scheduledMessages.list method
/// </summary>
public record ChatScheduledMessagesListschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("response_metadata")]
    public required ResponseMetadata ResponseMetadata { get; init; }

    [JsonPropertyName("scheduled_messages")]
    public required IReadOnlyList<ScheduledMessage> ScheduledMessages { get; init; }
}
