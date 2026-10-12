using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminConversations;

/// <summary>
/// The inputs of the AdminConversationsDisconnectShared operation.
/// </summary>
public sealed record AdminConversationsDisconnectSharedRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.conversations:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// The channel to be disconnected from some workspaces.
    /// </summary>
    public required string ChannelId { get; init; }

    /// <summary>
    /// The team to be removed from the channel. Currently only a single team id can be specified.
    /// </summary>
    public string? LeavingTeamIds { get; init; }
}
