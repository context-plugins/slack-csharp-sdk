using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Conversations;

/// <summary>
/// The inputs of the ConversationsUnarchive operation.
/// </summary>
public sealed record ConversationsUnarchiveRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>conversations:write</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// ID of conversation to unarchive
    /// </summary>
    public string? Channel { get; init; }
}
