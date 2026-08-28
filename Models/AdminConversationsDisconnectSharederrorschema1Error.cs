using System.Text.Json.Serialization;
using Slack.Core.Models;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response from admin.conversations.disconnectShared
/// </summary>
public record AdminConversationsDisconnectSharederrorschema1Error
{
    [JsonPropertyName("error")]
    public required AdminConversationsDisconnectSharedErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
