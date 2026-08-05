using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response conversations.mark method
/// </summary>
public record ConversationsMarksuccessschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
