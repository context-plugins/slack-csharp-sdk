using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.FilesRemote;

/// <summary>
/// The inputs of the FilesRemoteList operation.
/// </summary>
public sealed record FilesRemoteListRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>remote_files:read</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Filter files appearing in a specific channel, indicated by its ID.
    /// </summary>
    public string? Channel { get; init; }

    /// <summary>
    /// Filter files created after this timestamp (inclusive).
    /// </summary>
    public double? TsFrom { get; init; }

    /// <summary>
    /// Filter files created before this timestamp (inclusive).
    /// </summary>
    public double? TsTo { get; init; }

    /// <summary>
    /// The maximum number of items to return.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Paginate through collections of data by setting the <c>cursor</c> parameter to a <c>next_cursor</c> attribute returned by a previous request's <c>response_metadata</c>. Default value fetches the first "page" of the collection.
    /// </summary>
    public string? Cursor { get; init; }

    public required ContentType ContentType { get; init; }
}
