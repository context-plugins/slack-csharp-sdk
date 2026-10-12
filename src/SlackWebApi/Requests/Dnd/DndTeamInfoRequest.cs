using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Dnd;

/// <summary>
/// The inputs of the DndTeamInfo operation.
/// </summary>
public sealed record DndTeamInfoRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>dnd:read</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Comma-separated list of users to fetch Do Not Disturb status for
    /// </summary>
    public string? Users { get; init; }

    public required ContentType ContentType { get; init; }
}
