using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for error response from admin.conversations.convertToPrivate
/// </summary>
public record AdminConversationsConvertToPrivateerrorschema1Error
{
    [JsonPropertyName("error")]
    public required AdminConversationsConvertToPrivateErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public string Ok { get; } = "False";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
