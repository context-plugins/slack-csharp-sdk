using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminEmoji;

/// <summary>
/// The inputs of the AdminEmojiList operation.
/// </summary>
public sealed record AdminEmojiListRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.teams:read</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// The maximum number of items to return. Must be between 1 - 1000 both inclusive.
    /// </summary>
    public int? Limit { get; init; }

    public required ContentType ContentType { get; init; }
}
