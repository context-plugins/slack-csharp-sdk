using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.TeamApi;

/// <summary>
/// The inputs of the TeamAccessLogs operation.
/// </summary>
public sealed record TeamAccessLogsRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// End of time range of logs to include in results (inclusive).
    /// </summary>
    public string? Before { get; init; }

    public string? Count { get; init; }

    public string? Page { get; init; }

    public required ContentType ContentType { get; init; }
}
