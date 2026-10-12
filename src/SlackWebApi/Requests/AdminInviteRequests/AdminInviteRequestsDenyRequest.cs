using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminInviteRequests;

/// <summary>
/// The inputs of the AdminInviteRequestsDeny operation.
/// </summary>
public sealed record AdminInviteRequestsDenyRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.invites:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// ID of the request to invite.
    /// </summary>
    public required string InviteRequestId { get; init; }

    /// <summary>
    /// ID for the workspace where the invite request was made.
    /// </summary>
    public string? TeamId { get; init; }
}
