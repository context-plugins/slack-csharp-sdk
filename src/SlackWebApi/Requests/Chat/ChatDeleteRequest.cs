using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Chat;

/// <summary>
/// The inputs of the ChatDelete operation.
/// </summary>
public sealed record ChatDeleteRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>chat:write</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Timestamp of the message to be deleted.
    /// </summary>
    public double? Ts { get; init; }

    /// <summary>
    /// Channel containing the message to be deleted.
    /// </summary>
    public string? Channel { get; init; }

    /// <summary>
    /// Pass true to delete the message as the authed user with <c>chat:write:user</c> scope. <see href="/bot-users">Bot users</see> in this context are considered authed users. If unused or false, the message will be deleted with <c>chat:write:bot</c> scope.
    /// </summary>
    public bool? AsUser { get; init; }
}
