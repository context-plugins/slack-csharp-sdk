using System.Collections.Generic;
using System.Text.Json.Serialization;
using Slack.Core.Models;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from chat.scheduledMessages.list method
/// </summary>
public record ChatScheduledMessagesListschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("response_metadata")]
    public required ResponseMetadata ResponseMetadata { get; init; }

    [JsonPropertyName("scheduled_messages")]
    public required IReadOnlyList<ScheduledMessage> ScheduledMessages { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
