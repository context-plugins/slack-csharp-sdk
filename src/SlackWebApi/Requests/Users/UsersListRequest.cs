using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Users;

/// <summary>
/// The inputs of the UsersList operation.
/// </summary>
public sealed record UsersListRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>users:read</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the users list hasn't been reached. Providing no <c>limit</c> value will result in Slack attempting to deliver you the entire result set. If the collection is too large you may experience <c>limit_required</c> or HTTP 500 errors.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Paginate through collections of data by setting the <c>cursor</c> parameter to a <c>next_cursor</c> attribute returned by a previous request's <c>response_metadata</c>. Default value fetches the first "page" of the collection.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// Set this to <c>true</c> to receive the locale for users. Defaults to <c>false</c>
    /// </summary>
    public bool? IncludeLocale { get; init; }

    public required ContentType ContentType { get; init; }
}
