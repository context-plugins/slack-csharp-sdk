using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminUsersSession;

/// <summary>
/// The inputs of the AdminUsersSessionInvalidate operation.
/// </summary>
public sealed record AdminUsersSessionInvalidateRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.users:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// ID of the team that the session belongs to
    /// </summary>
    public required string TeamId { get; init; }

    public required int SessionId { get; init; }
}
