using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Emoji;

/// <summary>
/// The inputs of the EmojiList operation.
/// </summary>
public sealed record EmojiListRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>emoji:read</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }
}
