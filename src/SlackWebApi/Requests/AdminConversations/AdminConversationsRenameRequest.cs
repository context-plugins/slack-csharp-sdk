using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminConversations;

/// <summary>
/// The inputs of the AdminConversationsRename operation.
/// </summary>
public sealed record AdminConversationsRenameRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.conversations:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// The channel to rename.
    /// </summary>
    public required string ChannelId { get; init; }

    public required string Name { get; init; }
}
