using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Search;

/// <summary>
/// The inputs of the SearchMessages operation.
/// </summary>
public sealed record SearchMessagesRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>search:read</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// Search query.
    /// </summary>
    public required string Query { get; init; }

    /// <summary>
    /// Pass the number of results you want per "page". Maximum of <c>100</c>.
    /// </summary>
    public int? Count { get; init; }

    /// <summary>
    /// Pass a value of <c>true</c> to enable query highlight markers (see below).
    /// </summary>
    public bool? Highlight { get; init; }

    public int? Page { get; init; }

    /// <summary>
    /// Return matches sorted by either <c>score</c> or <c>timestamp</c>.
    /// </summary>
    public string? Sort { get; init; }

    /// <summary>
    /// Change sort direction to ascending (<c>asc</c>) or descending (<c>desc</c>).
    /// </summary>
    public string? SortDir { get; init; }

    public required ContentType ContentType { get; init; }
}
