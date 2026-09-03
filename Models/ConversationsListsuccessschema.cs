using System.Collections.Generic;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;
using SlackWebApi.Core.Validation.Attributes;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from conversations.list method
/// </summary>
public record ConversationsListsuccessschema
{
    [JsonPropertyName("channels")]
    [UniqueItems]
    public required IReadOnlyList<object> Channels { get; init; }

    [JsonPropertyName("ok")]
    public string Ok { get; } = "True";

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response_metadata")]
    public ResponseMetadata? ResponseMetadata { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
