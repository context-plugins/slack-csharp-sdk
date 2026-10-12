using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Usergroups;

/// <summary>
/// The inputs of the UsergroupsList operation.
/// </summary>
public sealed record UsergroupsListRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>usergroups:read</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// Include the list of users for each User Group.
    /// </summary>
    public bool? IncludeUsers { get; init; }

    /// <summary>
    /// Include the number of users in each User Group.
    /// </summary>
    public bool? IncludeCount { get; init; }

    /// <summary>
    /// Include disabled User Groups.
    /// </summary>
    public bool? IncludeDisabled { get; init; }

    public required ContentType ContentType { get; init; }
}
