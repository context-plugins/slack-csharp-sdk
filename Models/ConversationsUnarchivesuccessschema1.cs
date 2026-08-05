using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from conversations.unarchive method
/// </summary>
public record ConversationsUnarchivesuccessschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
