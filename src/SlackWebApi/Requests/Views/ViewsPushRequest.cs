using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Views;

/// <summary>
/// The inputs of the ViewsPush operation.
/// </summary>
public sealed record ViewsPushRequest
{
    /// <summary>
    /// Exchange a trigger to post to the user.
    /// </summary>
    public required string TriggerId { get; init; }

    /// <summary>
    /// A <see href="/reference/surfaces/views">view payload</see>. This must be a JSON-encoded string.
    /// </summary>
    public required string View { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>none</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }
}
