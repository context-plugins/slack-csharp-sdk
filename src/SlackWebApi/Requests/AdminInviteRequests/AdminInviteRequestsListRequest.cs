using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminInviteRequests;

/// <summary>
/// The inputs of the AdminInviteRequestsList operation.
/// </summary>
public sealed record AdminInviteRequestsListRequest
{
    /// <summary>
    /// ID for the workspace where the invite requests were made.
    /// </summary>
    public string? TeamId { get; init; }

    /// <summary>
    /// Value of the <c>next_cursor</c> field sent as part of the previous API response
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// The number of results that will be returned by the API on each invocation. Must be between 1 - 1000, both inclusive
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>admin.invites:read</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }
}
