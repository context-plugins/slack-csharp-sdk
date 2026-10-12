using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Users;

/// <summary>
/// The inputs of the UsersLookupByEmail operation.
/// </summary>
public sealed record UsersLookupByEmailRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>users:read.email</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// An email address belonging to a user in the workspace
    /// </summary>
    public required string Email { get; init; }

    public required ContentType ContentType { get; init; }
}
