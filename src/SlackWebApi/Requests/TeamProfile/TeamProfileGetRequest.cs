using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.TeamProfile;

/// <summary>
/// The inputs of the TeamProfileGet operation.
/// </summary>
public sealed record TeamProfileGetRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>users.profile:read</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// Filter by visibility.
    /// </summary>
    public string? Visibility { get; init; }

    public required ContentType ContentType { get; init; }
}
