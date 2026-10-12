using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Users;

/// <summary>
/// The inputs of the UsersSetPresence operation.
/// </summary>
public sealed record UsersSetPresenceRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>users:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Either <c>auto</c> or <c>away</c>
    /// </summary>
    public required string Presence { get; init; }
}
