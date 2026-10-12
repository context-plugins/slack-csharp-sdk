using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminConversations;

/// <summary>
/// The inputs of the AdminConversationsArchive operation.
/// </summary>
public sealed record AdminConversationsArchiveRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.conversations:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// The channel to archive.
    /// </summary>
    public required string ChannelId { get; init; }
}
