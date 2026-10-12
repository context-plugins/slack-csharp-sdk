using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminUsers;

/// <summary>
/// The inputs of the AdminUsersAssign operation.
/// </summary>
public sealed record AdminUsersAssignRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.users:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// The ID (<c>T1234</c>) of the workspace.
    /// </summary>
    public required string TeamId { get; init; }

    /// <summary>
    /// The ID of the user to add to the workspace.
    /// </summary>
    public required string UserId { get; init; }

    /// <summary>
    /// True if user should be added to the workspace as a guest.
    /// </summary>
    public bool? IsRestricted { get; init; }

    /// <summary>
    /// True if user should be added to the workspace as a single-channel guest.
    /// </summary>
    public bool? IsUltraRestricted { get; init; }

    /// <summary>
    /// Comma separated values of channel IDs to add user in the new workspace.
    /// </summary>
    public string? ChannelIds { get; init; }
}
