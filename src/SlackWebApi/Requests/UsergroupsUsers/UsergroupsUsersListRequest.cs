using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.UsergroupsUsers;

/// <summary>
/// The inputs of the UsergroupsUsersList operation.
/// </summary>
public sealed record UsergroupsUsersListRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>usergroups:read</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// The encoded ID of the User Group to update.
    /// </summary>
    public required string Usergroup { get; init; }

    /// <summary>
    /// Allow results that involve disabled User Groups.
    /// </summary>
    public bool? IncludeDisabled { get; init; }

    public required ContentType ContentType { get; init; }
}
