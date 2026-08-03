using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response conversations.kick method
/// </summary>
public record ConversationsKicksuccessschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
