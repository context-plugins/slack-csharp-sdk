using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Conversations;

/// <summary>
/// The inputs of the ConversationsInfo operation.
/// </summary>
public sealed record ConversationsInfoRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>conversations:read</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Conversation ID to learn more about
    /// </summary>
    public string? Channel { get; init; }

    /// <summary>
    /// Set this to <c>true</c> to receive the locale for this conversation. Defaults to <c>false</c>
    /// </summary>
    public bool? IncludeLocale { get; init; }

    /// <summary>
    /// Set to <c>true</c> to include the member count for the specified conversation. Defaults to <c>false</c>
    /// </summary>
    public bool? IncludeNumMembers { get; init; }

    public required ContentType ContentType { get; init; }
}
