using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Migration;

/// <summary>
/// The inputs of the MigrationExchange operation.
/// </summary>
public sealed record MigrationExchangeRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>tokens.basic</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// A comma-separated list of user ids, up to 400 per request
    /// </summary>
    public required string Users { get; init; }

    /// <summary>
    /// Specify team_id starts with <c>T</c> in case of Org Token
    /// </summary>
    public string? TeamId { get; init; }

    /// <summary>
    /// Specify <c>true</c> to convert <c>W</c> global user IDs to workspace-specific <c>U</c> IDs. Defaults to <c>false</c>.
    /// </summary>
    public bool? ToOld { get; init; }

    public required ContentType ContentType { get; init; }
}
