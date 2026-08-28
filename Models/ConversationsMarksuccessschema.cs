using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response conversations.mark method
/// </summary>
public record ConversationsMarksuccessschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
