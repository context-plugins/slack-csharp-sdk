using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from conversations.unarchive method
/// </summary>
public record ConversationsUnarchivesuccessschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
