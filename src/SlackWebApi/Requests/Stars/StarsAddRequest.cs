using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Stars;

/// <summary>
/// The inputs of the StarsAdd operation.
/// </summary>
public sealed record StarsAddRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>stars:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Channel to add star to, or channel where the message to add star to was posted (used with <c>timestamp</c>).
    /// </summary>
    public string? Channel { get; init; }

    /// <summary>
    /// File to add star to.
    /// </summary>
    public string? File { get; init; }

    /// <summary>
    /// File comment to add star to.
    /// </summary>
    public string? FileComment { get; init; }

    /// <summary>
    /// Timestamp of the message to add star to.
    /// </summary>
    public string? Timestamp { get; init; }
}
