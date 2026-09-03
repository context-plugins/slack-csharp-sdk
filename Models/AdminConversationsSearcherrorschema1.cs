using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for error response from admin.conversations.search
/// </summary>
public record AdminConversationsSearcherrorschema1
{
    [JsonPropertyName("error")]
    public required AdminConversationsSearchErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public string Ok { get; } = "False";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
