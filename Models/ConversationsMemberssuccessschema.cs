using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Slack.Core.Models;
using Slack.Core.Validation.Attributes;

namespace Slack.Models;

/// <summary>
/// Schema for successful response conversations.members method
/// </summary>
public record ConversationsMemberssuccessschema
{
    [JsonPropertyName("members")]
    [MinLength(1)]
    [UniqueItems]
    public required IReadOnlyList<string> Members { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("response_metadata")]
    public required ResponseMetadata ResponseMetadata { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
