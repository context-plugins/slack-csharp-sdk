using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Slack.Core.Validation.Attributes;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from conversations.history method
/// </summary>
public record ConversationsHistorysuccessschema
{
    [JsonPropertyName("channel_actions_count")]
    public required int ChannelActionsCount { get; init; }

    [JsonPropertyName("channel_actions_ts")]
    public required object ChannelActionsTs { get; init; }

    [JsonPropertyName("has_more")]
    public required bool HasMore { get; init; }

    [JsonPropertyName("messages")]
    [MinLength(1)]
    [UniqueItems]
    public required IReadOnlyList<Messageobject> Messages { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("pin_count")]
    public required int PinCount { get; init; }
}
