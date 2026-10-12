using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Dnd;

/// <summary>
/// The inputs of the DndSetSnooze operation.
/// </summary>
public sealed record DndSetSnoozeRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>dnd:write</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// Number of minutes, from now, to snooze until.
    /// </summary>
    public required string NumMinutes { get; init; }
}
