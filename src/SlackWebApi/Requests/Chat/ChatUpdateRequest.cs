using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Chat;

/// <summary>
/// The inputs of the ChatUpdate operation.
/// </summary>
public sealed record ChatUpdateRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>chat:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Channel containing the message to be updated.
    /// </summary>
    public required string Channel { get; init; }

    /// <summary>
    /// Timestamp of the message to be updated.
    /// </summary>
    public required string Ts { get; init; }

    /// <summary>
    /// Pass true to update the message as the authed user. <see href="/bot-users">Bot users</see> in this context are considered authed users.
    /// </summary>
    public string? AsUser { get; init; }

    /// <summary>
    /// A JSON-based array of structured attachments, presented as a URL-encoded string. This field is required when not presenting <c>text</c>. If you don't include this field, the message's previous <c>attachments</c> will be retained. To remove previous <c>attachments</c>, include an empty array for this field.
    /// </summary>
    public string? Attachments { get; init; }

    /// <summary>
    /// A JSON-based array of <see href="/block-kit/building">structured blocks</see>, presented as a URL-encoded string. If you don't include this field, the message's previous <c>blocks</c> will be retained. To remove previous <c>blocks</c>, include an empty array for this field.
    /// </summary>
    public string? Blocks { get; init; }

    /// <summary>
    /// Find and link channel names and usernames. Defaults to <c>none</c>. If you do not specify a value for this field, the original value set for the message will be overwritten with the default, <c>none</c>.
    /// </summary>
    public string? LinkNames { get; init; }

    /// <summary>
    /// Change how messages are treated. Defaults to <c>client</c>, unlike <c>chat.postMessage</c>. Accepts either <c>none</c> or <c>full</c>. If you do not specify a value for this field, the original value set for the message will be overwritten with the default, <c>client</c>.
    /// </summary>
    public string? Parse { get; init; }

    /// <summary>
    /// New text for the message, using the <see href="/reference/surfaces/formatting">default formatting rules</see>. It's not required when presenting <c>blocks</c> or <c>attachments</c>.
    /// </summary>
    public string? Text { get; init; }
}
