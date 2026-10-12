using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminUsergroups;

/// <summary>
/// The inputs of the AdminUsergroupsAddTeams operation.
/// </summary>
public sealed record AdminUsergroupsAddTeamsRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.teams:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// An encoded usergroup (IDP Group) ID.
    /// </summary>
    public required string UsergroupId { get; init; }

    /// <summary>
    /// A comma separated list of encoded team (workspace) IDs. Each workspace *MUST* belong to the organization associated with the token.
    /// </summary>
    public required string TeamIds { get; init; }

    /// <summary>
    /// When <c>true</c>, this method automatically creates new workspace accounts for the IDP group members.
    /// </summary>
    public bool? AutoProvision { get; init; }
}
