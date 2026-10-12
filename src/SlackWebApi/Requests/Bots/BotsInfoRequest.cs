using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Bots;

/// <summary>
/// The inputs of the BotsInfo operation.
/// </summary>
public sealed record BotsInfoRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>users:read</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// Bot user to get info on
    /// </summary>
    public string? Bot { get; init; }

    public required ContentType ContentType { get; init; }
}
