using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Auth;

/// <summary>
/// The inputs of the AuthTest operation.
/// </summary>
public sealed record AuthTestRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>none</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }
}
