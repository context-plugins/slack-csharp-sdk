using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Conversations;

/// <summary>
/// The inputs of the ConversationsSetPurpose operation.
/// </summary>
public sealed record ConversationsSetPurposeRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>conversations:write</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Conversation to set the purpose of
    /// </summary>
    public string? Channel { get; init; }

    /// <summary>
    /// A new, specialer purpose
    /// </summary>
    public string? Purpose { get; init; }
}
