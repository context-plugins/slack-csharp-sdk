using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from conversations.setPurpose method
/// </summary>
public record ConversationsSetPurposesuccessschema1
{
    [JsonPropertyName("channel")]
    public required object Channel { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
