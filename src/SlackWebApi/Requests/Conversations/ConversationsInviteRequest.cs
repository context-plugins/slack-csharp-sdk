using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Conversations;

/// <summary>
/// The inputs of the ConversationsInvite operation.
/// </summary>
public sealed record ConversationsInviteRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>conversations:write</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// The ID of the public or private channel to invite user(s) to.
    /// </summary>
    public string? Channel { get; init; }

    /// <summary>
    /// A comma separated list of user IDs. Up to 1000 users may be listed.
    /// </summary>
    public string? Users { get; init; }
}
