using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminUsers;

/// <summary>
/// The inputs of the AdminUsersSetOwner operation.
/// </summary>
public sealed record AdminUsersSetOwnerRequest
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
    /// Id of the user to promote to owner.
    /// </summary>
    public required string UserId { get; init; }
}
