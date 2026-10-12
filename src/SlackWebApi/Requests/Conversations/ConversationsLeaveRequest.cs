using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Conversations;

/// <summary>
/// The inputs of the ConversationsLeave operation.
/// </summary>
public sealed record ConversationsLeaveRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>conversations:write</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Conversation to leave
    /// </summary>
    public string? Channel { get; init; }
}
