using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from conversations.unarchive method
/// </summary>
public record ConversationsUnarchivesuccessschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
