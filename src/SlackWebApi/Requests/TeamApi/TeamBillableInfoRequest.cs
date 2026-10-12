using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.TeamApi;

/// <summary>
/// The inputs of the TeamBillableInfo operation.
/// </summary>
public sealed record TeamBillableInfoRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// A user to retrieve the billable information for. Defaults to all users.
    /// </summary>
    public string? User { get; init; }

    public required ContentType ContentType { get; init; }
}
