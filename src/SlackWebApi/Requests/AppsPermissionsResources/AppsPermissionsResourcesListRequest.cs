using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AppsPermissionsResources;

/// <summary>
/// The inputs of the AppsPermissionsResourcesList operation.
/// </summary>
public sealed record AppsPermissionsResourcesListRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>none</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// Paginate through collections of data by setting the <c>cursor</c> parameter to a <c>next_cursor</c> attribute returned by a previous request's <c>response_metadata</c>. Default value fetches the first "page" of the collection.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// The maximum number of items to return.
    /// </summary>
    public int? Limit { get; init; }

    public required ContentType ContentType { get; init; }
}
