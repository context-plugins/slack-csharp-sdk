using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Users;

/// <summary>
/// The inputs of the UsersSetActive operation.
/// </summary>
public sealed record UsersSetActiveRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>users:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }
}
