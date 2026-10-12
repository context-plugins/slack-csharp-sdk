using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Users;

/// <summary>
/// The inputs of the UsersDeletePhoto operation.
/// </summary>
public sealed record UsersDeletePhotoRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>users.profile:write</c>
    /// </summary>
    public required string Token { get; init; }
}
