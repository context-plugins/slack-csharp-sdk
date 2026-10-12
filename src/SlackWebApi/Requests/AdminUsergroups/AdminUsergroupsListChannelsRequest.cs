using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminUsergroups;

/// <summary>
/// The inputs of the AdminUsergroupsListChannels operation.
/// </summary>
public sealed record AdminUsergroupsListChannelsRequest
{
    /// <summary>
    /// ID of the IDP group to list default channels for.
    /// </summary>
    public required string UsergroupId { get; init; }

    /// <summary>
    /// ID of the the workspace.
    /// </summary>
    public string? TeamId { get; init; }

    /// <summary>
    /// Flag to include or exclude the count of members per channel.
    /// </summary>
    public bool? IncludeNumMembers { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>admin.usergroups:read</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }
}
