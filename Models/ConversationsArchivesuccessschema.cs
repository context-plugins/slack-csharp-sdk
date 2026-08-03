using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response conversations.archive method
/// </summary>
public record ConversationsArchivesuccessschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
