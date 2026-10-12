using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Dnd;

/// <summary>
/// The inputs of the DndEndSnooze operation.
/// </summary>
public sealed record DndEndSnoozeRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>dnd:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }
}
