using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Pins;

/// <summary>
/// The inputs of the PinsRemove operation.
/// </summary>
public sealed record PinsRemoveRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>pins:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Channel where the item is pinned to.
    /// </summary>
    public required string Channel { get; init; }

    /// <summary>
    /// Timestamp of the message to un-pin.
    /// </summary>
    public string? Timestamp { get; init; }
}
