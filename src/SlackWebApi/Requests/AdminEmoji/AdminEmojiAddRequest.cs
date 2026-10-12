using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminEmoji;

/// <summary>
/// The inputs of the AdminEmojiAdd operation.
/// </summary>
public sealed record AdminEmojiAddRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>admin.teams:write</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// The name of the emoji to be removed. Colons (<c>:myemoji:</c>) around the value are not required, although they may be included.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// The URL of a file to use as an image for the emoji. Square images under 128KB and with transparent backgrounds work best.
    /// </summary>
    public required string Url { get; init; }
}
