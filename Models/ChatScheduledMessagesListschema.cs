using System.Collections.Generic;
using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from chat.scheduledMessages.list method
/// </summary>
public record ChatScheduledMessagesListschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("response_metadata")]
    public required ResponseMetadata ResponseMetadata { get; init; }

    [JsonPropertyName("scheduled_messages")]
    public required IReadOnlyList<ScheduledMessage> ScheduledMessages { get; init; }
}
