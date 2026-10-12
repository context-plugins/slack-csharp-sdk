using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Calls;

/// <summary>
/// The inputs of the CallsUpdate operation.
/// </summary>
public sealed record CallsUpdateRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>calls:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// <c>id</c> returned by the <see href="/methods/calls.add"><c>calls.add</c></see> method.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// The name of the Call.
    /// </summary>
    public string? Title { get; init; }

    /// <summary>
    /// The URL required for a client to join the Call.
    /// </summary>
    public string? JoinUrl { get; init; }

    /// <summary>
    /// When supplied, available Slack clients will attempt to directly launch the 3rd-party Call with this URL.
    /// </summary>
    public string? DesktopAppJoinUrl { get; init; }
}
