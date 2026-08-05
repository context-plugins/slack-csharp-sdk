using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response conversations.create method
/// </summary>
public record ConversationsCreatesuccessschema1
{
    [JsonPropertyName("channel")]
    public required object Channel { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
