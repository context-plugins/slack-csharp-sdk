using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for error response from admin.conversations.getTeams
/// </summary>
public record AdminConversationsGetTeamserrorschema1Error
{
    [JsonPropertyName("error")]
    public required AdminConversationsGetTeamsErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
