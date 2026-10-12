using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Dnd;

/// <summary>
/// The inputs of the DndInfo operation.
/// </summary>
public sealed record DndInfoRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>dnd:read</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// User to fetch status for (defaults to current user)
    /// </summary>
    public string? User { get; init; }

    public required ContentType ContentType { get; init; }
}
