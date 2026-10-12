using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Conversations;

/// <summary>
/// The inputs of the ConversationsRename operation.
/// </summary>
public sealed record ConversationsRenameRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>conversations:write</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// ID of conversation to rename
    /// </summary>
    public string? Channel { get; init; }

    /// <summary>
    /// New name for conversation.
    /// </summary>
    public string? Name { get; init; }
}
