using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Chat;

/// <summary>
/// The inputs of the ChatPostMessage operation.
/// </summary>
public sealed record ChatPostMessageRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>chat:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Channel, private group, or IM channel to send message to. Can be an encoded ID, or a name. See <see href="#channels">below</see> for more details.
    /// </summary>
    public required string Channel { get; init; }

    /// <summary>
    /// Pass true to post the message as the authed user, instead of as a bot. Defaults to false. See <see href="#authorship">authorship</see> below.
    /// </summary>
    public string? AsUser { get; init; }

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
    /// Disable Slack markup parsing by setting to <c>false</c>. Enabled by default.
    /// </summary>
    public bool? Mrkdwn { get; init; }

    /// <summary>
    /// Change how messages are treated. Defaults to <c>none</c>. See <see href="#formatting">below</see>.
    /// </summary>
    public string? Parse { get; init; }

    /// <summary>
    /// Used in conjunction with <c>thread_ts</c> and indicates whether reply should be made visible to everyone in the channel or conversation. Defaults to <c>false</c>.
    /// </summary>
    public bool? ReplyBroadcast { get; init; }

    /// <summary>
    /// How this field works and whether it is required depends on other fields you use in your API call. <see href="#text_usage">See below</see> for more detail.
    /// </summary>
    public string? Text { get; init; }

    /// <summary>
    /// Provide another message's <c>ts</c> value to make this message a reply. Avoid using a reply's <c>ts</c> value; use its parent instead.
    /// </summary>
    public string? ThreadTs { get; init; }

    /// <summary>
    /// Pass true to enable unfurling of primarily text-based content.
    /// </summary>
    public bool? UnfurlLinks { get; init; }

    /// <summary>
    /// Pass false to disable unfurling of media content.
    /// </summary>
    public bool? UnfurlMedia { get; init; }

    /// <summary>
    /// Set your bot's user name. Must be used in conjunction with <c>as_user</c> set to false, otherwise ignored. See <see href="#authorship">authorship</see> below.
    /// </summary>
    public string? Username { get; init; }
}
