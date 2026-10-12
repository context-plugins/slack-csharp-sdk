using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Conversations;

/// <summary>
/// The inputs of the ConversationsJoin operation.
/// </summary>
public sealed record ConversationsJoinRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>channels:write</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// ID of conversation to join
    /// </summary>
    public string? Channel { get; init; }
}
