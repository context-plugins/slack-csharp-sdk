using System.Collections.Generic;
using System.Text.Json.Serialization;
using Slack.Core.Validation.Attributes;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from conversations.list method
/// </summary>
public record ConversationsListsuccessschema
{
    [JsonPropertyName("channels")]
    [UniqueItems]
    public required IReadOnlyList<object> Channels { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response_metadata")]
    public ResponseMetadata? ResponseMetadata { get; init; }
}
