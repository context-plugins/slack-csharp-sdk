using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminConversations;

/// <summary>
/// The inputs of the AdminConversationsSetTeams operation.
/// </summary>
public sealed record AdminConversationsSetTeamsRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.conversations:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// The encoded <c>channel_id</c> to add or remove to workspaces.
    /// </summary>
    public required string ChannelId { get; init; }

    /// <summary>
    /// The workspace to which the channel belongs. Omit this argument if the channel is a cross-workspace shared channel.
    /// </summary>
    public string? TeamId { get; init; }

    /// <summary>
    /// A comma-separated list of workspaces to which the channel should be shared. Not required if the channel is being shared org-wide.
    /// </summary>
    public string? TargetTeamIds { get; init; }

    /// <summary>
    /// True if channel has to be converted to an org channel
    /// </summary>
    public bool? OrgChannel { get; init; }
}
