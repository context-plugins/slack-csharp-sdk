using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminUsers;

/// <summary>
/// The inputs of the AdminUsersRemove operation.
/// </summary>
public sealed record AdminUsersRemoveRequest
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
    /// The ID of the user to remove.
    /// </summary>
    public required string UserId { get; init; }
}
