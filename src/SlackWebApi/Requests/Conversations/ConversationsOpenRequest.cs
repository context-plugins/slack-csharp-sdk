using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Conversations;

/// <summary>
/// The inputs of the ConversationsOpen operation.
/// </summary>
public sealed record ConversationsOpenRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>conversations:write</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Resume a conversation by supplying an <c>im</c> or <c>mpim</c>'s ID. Or provide the <c>users</c> field instead.
    /// </summary>
    public string? Channel { get; init; }

    /// <summary>
    /// Comma separated lists of users. If only one user is included, this creates a 1:1 DM.  The ordering of the users is preserved whenever a multi-person direct message is returned. Supply a <c>channel</c> when not supplying <c>users</c>.
    /// </summary>
    public string? Users { get; init; }

    /// <summary>
    /// Boolean, indicates you want the full IM channel definition in the response.
    /// </summary>
    public bool? ReturnIm { get; init; }
}
