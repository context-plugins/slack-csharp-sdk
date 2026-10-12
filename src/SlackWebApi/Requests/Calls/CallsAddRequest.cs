using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Calls;

/// <summary>
/// The inputs of the CallsAdd operation.
/// </summary>
public sealed record CallsAddRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>calls:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// An ID supplied by the 3rd-party Call provider. It must be unique across all Calls from that service.
    /// </summary>
    public required string ExternalUniqueId { get; init; }

    /// <summary>
    /// The URL required for a client to join the Call.
    /// </summary>
    public required string JoinUrl { get; init; }

    /// <summary>
    /// An optional, human-readable ID supplied by the 3rd-party Call provider. If supplied, this ID will be displayed in the Call object.
    /// </summary>
    public string? ExternalDisplayId { get; init; }

    /// <summary>
    /// When supplied, available Slack clients will attempt to directly launch the 3rd-party Call with this URL.
    /// </summary>
    public string? DesktopAppJoinUrl { get; init; }

    /// <summary>
    /// Call start time in UTC UNIX timestamp format
    /// </summary>
    public int? DateStart { get; init; }

    /// <summary>
    /// The name of the Call.
    /// </summary>
    public string? Title { get; init; }

    /// <summary>
    /// The valid Slack user ID of the user who created this Call. When this method is called with a user token, the <c>created_by</c> field is optional and defaults to the authed user of the token. Otherwise, the field is required.
    /// </summary>
    public string? CreatedBy { get; init; }

    /// <summary>
    /// The list of users to register as participants in the Call. <see href="/apis/calls#users">Read more on how to specify users here</see>.
    /// </summary>
    public string? Users { get; init; }
}
