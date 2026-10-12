using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Chat;

/// <summary>
/// The inputs of the ChatMeMessage operation.
/// </summary>
public sealed record ChatMeMessageRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>chat:write</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Channel to send message to. Can be a public channel, private group or IM channel. Can be an encoded ID, or a name.
    /// </summary>
    public string? Channel { get; init; }

    /// <summary>
    /// Text of the message to send.
    /// </summary>
    public string? Text { get; init; }
}
