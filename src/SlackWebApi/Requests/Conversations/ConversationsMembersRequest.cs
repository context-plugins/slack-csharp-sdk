using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Conversations;

/// <summary>
/// The inputs of the ConversationsMembers operation.
/// </summary>
public sealed record ConversationsMembersRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>conversations:read</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// ID of the conversation to retrieve members for
    /// </summary>
    public string? Channel { get; init; }

    /// <summary>
    /// The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the users list hasn't been reached.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Paginate through collections of data by setting the <c>cursor</c> parameter to a <c>next_cursor</c> attribute returned by a previous request's <c>response_metadata</c>. Default value fetches the first "page" of the collection.
    /// </summary>
    public string? Cursor { get; init; }

    public required ContentType ContentType { get; init; }
}
