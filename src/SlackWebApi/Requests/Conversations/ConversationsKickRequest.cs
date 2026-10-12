using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Conversations;

/// <summary>
/// The inputs of the ConversationsKick operation.
/// </summary>
public sealed record ConversationsKickRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>conversations:write</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// ID of conversation to remove user from.
    /// </summary>
    public string? Channel { get; init; }

    /// <summary>
    /// User ID to be removed.
    /// </summary>
    public string? User { get; init; }
}
