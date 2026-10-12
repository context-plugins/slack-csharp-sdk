using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminUsersSession;

/// <summary>
/// The inputs of the AdminUsersSessionReset operation.
/// </summary>
public sealed record AdminUsersSessionResetRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.users:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// The ID of the user to wipe sessions for
    /// </summary>
    public required string UserId { get; init; }

    /// <summary>
    /// Only expire mobile sessions (default: false)
    /// </summary>
    public bool? MobileOnly { get; init; }

    /// <summary>
    /// Only expire web sessions (default: false)
    /// </summary>
    public bool? WebOnly { get; init; }
}
