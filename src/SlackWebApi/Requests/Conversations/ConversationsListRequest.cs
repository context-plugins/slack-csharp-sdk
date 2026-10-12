using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Conversations;

/// <summary>
/// The inputs of the ConversationsList operation.
/// </summary>
public sealed record ConversationsListRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>conversations:read</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Set to <c>true</c> to exclude archived channels from the list
    /// </summary>
    public bool? ExcludeArchived { get; init; }

    /// <summary>
    /// Mix and match channel types by providing a comma-separated list of any combination of <c>public_channel</c>, <c>private_channel</c>, <c>mpim</c>, <c>im</c>
    /// </summary>
    public string? Types { get; init; }

    /// <summary>
    /// The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the list hasn't been reached. Must be an integer no larger than 1000.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Paginate through collections of data by setting the <c>cursor</c> parameter to a <c>next_cursor</c> attribute returned by a previous request's <c>response_metadata</c>. Default value fetches the first "page" of the collection.
    /// </summary>
    public string? Cursor { get; init; }

    public required ContentType ContentType { get; init; }
}
