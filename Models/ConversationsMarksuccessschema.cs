using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response conversations.mark method
/// </summary>
public record ConversationsMarksuccessschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
