using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminConversations;

/// <summary>
/// The inputs of the AdminConversationsSearch operation.
/// </summary>
public sealed record AdminConversationsSearchRequest
{
    /// <summary>
    /// Comma separated string of team IDs, signifying the workspaces to search through.
    /// </summary>
    public string? TeamIds { get; init; }

    /// <summary>
    /// Name of the the channel to query by.
    /// </summary>
    public string? Query { get; init; }

    /// <summary>
    /// Maximum number of items to be returned. Must be between 1 - 20 both inclusive. Default is 10.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// The type of channel to include or exclude in the search. For example <c>private</c> will search private channels, while <c>private_exclude</c> will exclude them. For a full list of types, check the <see href="#types">Types section</see>.
    /// </summary>
    public string? SearchChannelTypes { get; init; }

    /// <summary>
    /// Possible values are <c>relevant</c> (search ranking based on what we think is closest), <c>name</c> (alphabetical), <c>member_count</c> (number of users in the channel), and <c>created</c> (date channel was created). You can optionally pair this with the <c>sort_dir</c> arg to change how it is sorted
    /// </summary>
    public string? Sort { get; init; }

    /// <summary>
    /// Sort direction. Possible values are <c>asc</c> for ascending order like (1, 2, 3) or (a, b, c), and <c>desc</c> for descending order like (3, 2, 1) or (c, b, a)
    /// </summary>
    public string? SortDir { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>admin.conversations:read</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }
}
