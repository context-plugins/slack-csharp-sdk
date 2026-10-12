using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Usergroups;

/// <summary>
/// The inputs of the UsergroupsCreate operation.
/// </summary>
public sealed record UsergroupsCreateRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>usergroups:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// A name for the User Group. Must be unique among User Groups.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// A comma separated string of encoded channel IDs for which the User Group uses as a default.
    /// </summary>
    public string? Channels { get; init; }

    /// <summary>
    /// A short description of the User Group.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    /// A mention handle. Must be unique among channels, users and User Groups.
    /// </summary>
    public string? Handle { get; init; }

    /// <summary>
    /// Include the number of users in each User Group.
    /// </summary>
    public bool? IncludeCount { get; init; }
}
