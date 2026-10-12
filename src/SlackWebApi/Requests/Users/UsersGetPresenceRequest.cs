using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Users;

/// <summary>
/// The inputs of the UsersGetPresence operation.
/// </summary>
public sealed record UsersGetPresenceRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>users:read</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// User to get presence info on. Defaults to the authed user.
    /// </summary>
    public string? User { get; init; }

    public required ContentType ContentType { get; init; }
}
