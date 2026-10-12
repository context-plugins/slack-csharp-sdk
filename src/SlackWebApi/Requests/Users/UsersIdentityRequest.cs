using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Users;

/// <summary>
/// The inputs of the UsersIdentity operation.
/// </summary>
public sealed record UsersIdentityRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>identity.basic</c>
    /// </summary>
    public string? Token { get; init; }

    public required ContentType ContentType { get; init; }
}
