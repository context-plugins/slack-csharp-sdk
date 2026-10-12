using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminConversations;

/// <summary>
/// The inputs of the AdminConversationsInvite operation.
/// </summary>
public sealed record AdminConversationsInviteRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.conversations:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// The users to invite.
    /// </summary>
    public required string UserIds { get; init; }

    /// <summary>
    /// The channel that the users will be invited to.
    /// </summary>
    public required string ChannelId { get; init; }
}
