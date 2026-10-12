using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminTeamsAdmins;

/// <summary>
/// The inputs of the AdminTeamsAdminsList operation.
/// </summary>
public sealed record AdminTeamsAdminsListRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.teams:read</c>
    /// </summary>
    public required string Token { get; init; }

    public required string TeamId { get; init; }

    /// <summary>
    /// The maximum number of items to return.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page.
    /// </summary>
    public string? Cursor { get; init; }

    public required ContentType ContentType { get; init; }
}
