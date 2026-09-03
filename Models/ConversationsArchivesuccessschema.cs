using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response conversations.archive method
/// </summary>
public record ConversationsArchivesuccessschema
{
    [JsonPropertyName("ok")]
    public string Ok { get; } = "True";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
