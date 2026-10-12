using System.Collections.Generic;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;
using SlackWebApi.Core.Validation.Attributes;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from users.conversations method. Returned conversation objects do not include <c>num_members</c> or <c>is_member</c>
/// </summary>
public record UsersConversationssuccessschema
{
    [JsonPropertyName("channels")]
    [UniqueItems]
    public required IReadOnlyList<object> Channels { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response_metadata")]
    public ResponseMetadata? ResponseMetadata { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
