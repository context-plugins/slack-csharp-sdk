using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminTeams;

/// <summary>
/// The inputs of the AdminTeamsCreate operation.
/// </summary>
public sealed record AdminTeamsCreateRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.teams:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Team domain (for example, slacksoftballteam).
    /// </summary>
    public required string TeamDomain { get; init; }

    /// <summary>
    /// Team name (for example, Slack Softball Team).
    /// </summary>
    public required string TeamName { get; init; }

    /// <summary>
    /// Description for the team.
    /// </summary>
    public string? TeamDescription { get; init; }

    /// <summary>
    /// Who can join the team. A team's discoverability can be <c>open</c>, <c>closed</c>, <c>invite_only</c>, or <c>unlisted</c>.
    /// </summary>
    public string? TeamDiscoverability { get; init; }
}
