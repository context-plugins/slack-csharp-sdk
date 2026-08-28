using System.Collections.Generic;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response of admin.conversations.getTeams
/// </summary>
public record AdminConversationsGetTeamsschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response_metadata")]
    public ResponseMetadata? ResponseMetadata { get; init; }

    [JsonPropertyName("team_ids")]
    public required IReadOnlyList<string> TeamIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
