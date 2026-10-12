using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Stars;

/// <summary>
/// The inputs of the StarsList operation.
/// </summary>
public sealed record StarsListRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>stars:read</c>
    /// </summary>
    public string? Token { get; init; }

    public string? Count { get; init; }

    public string? Page { get; init; }

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
