using System.Text.Json.Serialization;
using Slack.Core.Models;

namespace Slack.Models;

/// <summary>
/// Schema for successful response of admin.conversations.unarchive
/// </summary>
public record AdminConversationsUnarchiveschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
