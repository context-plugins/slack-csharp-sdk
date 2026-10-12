using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.TeamApi;

/// <summary>
/// The inputs of the TeamInfo operation.
/// </summary>
public sealed record TeamInfoRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>team:read</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// Team to get info on, if omitted, will return information about the current team. Will only return team that the authenticated token is allowed to see through external shared channels
    /// </summary>
    public string? Team { get; init; }

    public required ContentType ContentType { get; init; }
}
