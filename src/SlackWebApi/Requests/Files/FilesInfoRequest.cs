using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Files;

/// <summary>
/// The inputs of the FilesInfo operation.
/// </summary>
public sealed record FilesInfoRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>files:read</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Specify a file by providing its ID.
    /// </summary>
    public string? File { get; init; }

    public string? Count { get; init; }

    public string? Page { get; init; }

    /// <summary>
    /// The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the list hasn't been reached.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Parameter for pagination. File comments are paginated for a single file. Set <c>cursor</c> equal to the <c>next_cursor</c> attribute returned by the previous request's <c>response_metadata</c>. This parameter is optional, but pagination is mandatory: the default value simply fetches the first "page" of the collection of comments.
    /// </summary>
    public string? Cursor { get; init; }

    public required ContentType ContentType { get; init; }
}
