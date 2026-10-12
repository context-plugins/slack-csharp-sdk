using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Pins;

/// <summary>
/// The inputs of the PinsAdd operation.
/// </summary>
public sealed record PinsAddRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>pins:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Channel to pin the item in.
    /// </summary>
    public required string Channel { get; init; }

    /// <summary>
    /// Timestamp of the message to pin.
    /// </summary>
    public string? Timestamp { get; init; }
}
