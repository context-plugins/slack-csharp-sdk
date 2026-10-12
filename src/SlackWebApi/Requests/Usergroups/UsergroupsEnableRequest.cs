using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Usergroups;

/// <summary>
/// The inputs of the UsergroupsEnable operation.
/// </summary>
public sealed record UsergroupsEnableRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>usergroups:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// The encoded ID of the User Group to enable.
    /// </summary>
    public required string Usergroup { get; init; }

    /// <summary>
    /// Include the number of users in the User Group.
    /// </summary>
    public bool? IncludeCount { get; init; }
}
