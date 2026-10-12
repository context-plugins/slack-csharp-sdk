using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminConversations;

/// <summary>
/// The inputs of the AdminConversationsDelete operation.
/// </summary>
public sealed record AdminConversationsDeleteRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.conversations:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// The channel to delete.
    /// </summary>
    public required string ChannelId { get; init; }
}
