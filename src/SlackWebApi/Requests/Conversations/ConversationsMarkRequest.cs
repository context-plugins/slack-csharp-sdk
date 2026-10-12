using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Conversations;

/// <summary>
/// The inputs of the ConversationsMark operation.
/// </summary>
public sealed record ConversationsMarkRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>conversations:write</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Channel or conversation to set the read cursor for.
    /// </summary>
    public string? Channel { get; init; }

    /// <summary>
    /// Unique identifier of message you want marked as most recently seen in this conversation.
    /// </summary>
    public double? Ts { get; init; }
}
