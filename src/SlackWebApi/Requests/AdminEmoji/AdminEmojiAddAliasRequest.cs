using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminEmoji;

/// <summary>
/// The inputs of the AdminEmojiAddAlias operation.
/// </summary>
public sealed record AdminEmojiAddAliasRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>admin.teams:write</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// The name of the emoji to be aliased. Colons (<c>:myemoji:</c>) around the value are not required, although they may be included.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// The alias of the emoji.
    /// </summary>
    public required string AliasFor { get; init; }
}
