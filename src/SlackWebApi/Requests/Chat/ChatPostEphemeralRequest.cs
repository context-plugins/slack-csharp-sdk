using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Chat;

/// <summary>
/// The inputs of the ChatPostEphemeral operation.
/// </summary>
public sealed record ChatPostEphemeralRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>chat:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Channel, private group, or IM channel to send message to. Can be an encoded ID, or a name.
    /// </summary>
    public required string Channel { get; init; }

    /// <summary>
    /// <c>id</c> of the user who will receive the ephemeral message. The user should be in the channel specified by the <c>channel</c> argument.
    /// </summary>
    public required string User { get; init; }

    /// <summary>
    /// Pass true to post the message as the authed user. Defaults to true if the chat:write:bot scope is not included. Otherwise, defaults to false.
    /// </summary>
    public bool? AsUser { get; init; }

    /// <summary>
    /// A JSON-based array of structured attachments, presented as a URL-encoded string.
    /// </summary>
    public string? Attachments { get; init; }

    /// <summary>
    /// A JSON-based array of structured blocks, presented as a URL-encoded string.
    /// </summary>
    public string? Blocks { get; init; }

    /// <summary>
    /// Emoji to use as the icon for this message. Overrides <c>icon_url</c>. Must be used in conjunction with <c>as_user</c> set to <c>false</c>, otherwise ignored. See <see href="#authorship">authorship</see> below.
    /// </summary>
    public string? IconEmoji { get; init; }

    /// <summary>
    /// URL to an image to use as the icon for this message. Must be used in conjunction with <c>as_user</c> set to false, otherwise ignored. See <see href="#authorship">authorship</see> below.
    /// </summary>
    public string? IconUrl { get; init; }

    /// <summary>
    /// Find and link channel names and usernames.
    /// </summary>
    public bool? LinkNames { get; init; }

    /// <summary>
    /// Change how messages are treated. Defaults to <c>none</c>. See <see href="#formatting">below</see>.
    /// </summary>
    public string? Parse { get; init; }

    /// <summary>
    /// How this field works and whether it is required depends on other fields you use in your API call. <see href="#text_usage">See below</see> for more detail.
    /// </summary>
    public string? Text { get; init; }

    /// <summary>
    /// Provide another message's <c>ts</c> value to post this message in a thread. Avoid using a reply's <c>ts</c> value; use its parent's value instead. Ephemeral messages in threads are only shown if there is already an active thread.
    /// </summary>
    public string? ThreadTs { get; init; }

    /// <summary>
    /// Set your bot's user name. Must be used in conjunction with <c>as_user</c> set to false, otherwise ignored. See <see href="#authorship">authorship</see> below.
    /// </summary>
    public string? Username { get; init; }
}
