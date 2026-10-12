using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.UsergroupsUsers;

/// <summary>
/// The inputs of the UsergroupsUsersUpdate operation.
/// </summary>
public sealed record UsergroupsUsersUpdateRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>usergroups:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// The encoded ID of the User Group to update.
    /// </summary>
    public required string Usergroup { get; init; }

    /// <summary>
    /// A comma separated string of encoded user IDs that represent the entire list of users for the User Group.
    /// </summary>
    public required string Users { get; init; }

    /// <summary>
    /// Include the number of users in the User Group.
    /// </summary>
    public bool? IncludeCount { get; init; }
}
