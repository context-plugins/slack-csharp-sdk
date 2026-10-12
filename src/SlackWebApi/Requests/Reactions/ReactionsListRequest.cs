using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Reactions;

/// <summary>
/// The inputs of the ReactionsList operation.
/// </summary>
public sealed record ReactionsListRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>reactions:read</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// Show reactions made by this user. Defaults to the authed user.
    /// </summary>
    public string? User { get; init; }

    /// <summary>
    /// If true always return the complete reaction list.
    /// </summary>
    public bool? Full { get; init; }

    public int? Count { get; init; }

    public int? Page { get; init; }

    /// <summary>
    /// Parameter for pagination. Set <c>cursor</c> equal to the <c>next_cursor</c> attribute returned by the previous request's <c>response_metadata</c>. This parameter is optional, but pagination is mandatory: the default value simply fetches the first "page" of the collection.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the list hasn't been reached.
    /// </summary>
    public int? Limit { get; init; }

    public required ContentType ContentType { get; init; }
}
