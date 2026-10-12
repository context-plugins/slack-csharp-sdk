using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminUsers;

/// <summary>
/// The inputs of the AdminUsersSetExpiration operation.
/// </summary>
public sealed record AdminUsersSetExpirationRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.users:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// The ID (<c>T1234</c>) of the workspace.
    /// </summary>
    public required string TeamId { get; init; }

    /// <summary>
    /// The ID of the user to set an expiration for.
    /// </summary>
    public required string UserId { get; init; }

    /// <summary>
    /// Timestamp when guest account should be disabled.
    /// </summary>
    public required int ExpirationTs { get; init; }
}
