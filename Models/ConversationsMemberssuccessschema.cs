using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Validation.Attributes;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

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
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("response_metadata")]
    public required ResponseMetadata ResponseMetadata { get; init; }
}
