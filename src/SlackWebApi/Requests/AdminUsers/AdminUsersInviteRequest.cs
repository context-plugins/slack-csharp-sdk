using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminUsers;

/// <summary>
/// The inputs of the AdminUsersInvite operation.
/// </summary>
public sealed record AdminUsersInviteRequest
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
    /// The email address of the person to invite.
    /// </summary>
    public required string Email { get; init; }

    /// <summary>
    /// A comma-separated list of <c>channel_id</c>s for this user to join. At least one channel is required.
    /// </summary>
    public required string ChannelIds { get; init; }

    /// <summary>
    /// An optional message to send to the user in the invite email.
    /// </summary>
    public string? CustomMessage { get; init; }

    /// <summary>
    /// Full name of the user.
    /// </summary>
    public string? RealName { get; init; }

    /// <summary>
    /// Allow this invite to be resent in the future if a user has not signed up yet. (default: false)
    /// </summary>
    public bool? Resend { get; init; }

    /// <summary>
    /// Is this user a multi-channel guest user? (default: false)
    /// </summary>
    public bool? IsRestricted { get; init; }

    /// <summary>
    /// Is this user a single channel guest user? (default: false)
    /// </summary>
    public bool? IsUltraRestricted { get; init; }

    /// <summary>
    /// Timestamp when guest account should be disabled. Only include this timestamp if you are inviting a guest user and you want their account to expire on a certain date.
    /// </summary>
    public string? GuestExpirationTs { get; init; }
}
