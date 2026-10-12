using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Pins;

/// <summary>
/// The inputs of the PinsList operation.
/// </summary>
public sealed record PinsListRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>pins:read</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// Channel to get pinned items for.
    /// </summary>
    public required string Channel { get; init; }

    public required ContentType ContentType { get; init; }
}
