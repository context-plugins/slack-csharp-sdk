using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminUsers;

/// <summary>
/// The inputs of the AdminUsersList operation.
/// </summary>
public sealed record AdminUsersListRequest
{
    /// <summary>
    /// The ID (<c>T1234</c>) of the workspace.
    /// </summary>
    public required string TeamId { get; init; }

    /// <summary>
    /// Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// Limit for how many users to be retrieved per page
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>admin.users:read</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }
}
