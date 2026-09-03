using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for error response from admin.conversations.rename
/// </summary>
public record AdminConversationsUnarchiveerrorschema21
{
    [JsonPropertyName("error")]
    public required AdminConversationsRenameErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public string Ok { get; } = "False";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
