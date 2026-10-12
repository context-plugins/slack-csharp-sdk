using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Chat;

/// <summary>
/// The inputs of the ChatDeleteScheduledMessage operation.
/// </summary>
public sealed record ChatDeleteScheduledMessageRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>chat:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// The channel the scheduled_message is posting to
    /// </summary>
    public required string Channel { get; init; }

    /// <summary>
    /// <c>scheduled_message_id</c> returned from call to chat.scheduleMessage
    /// </summary>
    public required string ScheduledMessageId { get; init; }

    /// <summary>
    /// Pass true to delete the message as the authed user with <c>chat:write:user</c> scope. <see href="/bot-users">Bot users</see> in this context are considered authed users. If unused or false, the message will be deleted with <c>chat:write:bot</c> scope.
    /// </summary>
    public bool? AsUser { get; init; }
}
