using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Stars;

/// <summary>
/// The inputs of the StarsRemove operation.
/// </summary>
public sealed record StarsRemoveRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>stars:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Channel to remove star from, or channel where the message to remove star from was posted (used with <c>timestamp</c>).
    /// </summary>
    public string? Channel { get; init; }

    /// <summary>
    /// File to remove star from.
    /// </summary>
    public string? File { get; init; }

    /// <summary>
    /// File comment to remove star from.
    /// </summary>
    public string? FileComment { get; init; }

    /// <summary>
    /// Timestamp of the message to remove star from.
    /// </summary>
    public string? Timestamp { get; init; }
}
