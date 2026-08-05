using System.Collections.Generic;
using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from conversations.replies method
/// </summary>
public record ConversationsRepliessuccessschema1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; init; }

    [JsonPropertyName("messages")]
    public required IReadOnlyList<object> Messages { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
