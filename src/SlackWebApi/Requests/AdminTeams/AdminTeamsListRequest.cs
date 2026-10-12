using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminTeams;

/// <summary>
/// The inputs of the AdminTeamsList operation.
/// </summary>
public sealed record AdminTeamsListRequest
{
    /// <summary>
    /// The maximum number of items to return. Must be between 1 - 100 both inclusive.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>admin.teams:read</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }
}
