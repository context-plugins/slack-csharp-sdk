using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.UsersProfile;

/// <summary>
/// The inputs of the UsersProfileGet operation.
/// </summary>
public sealed record UsersProfileGetRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>users.profile:read</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// Include labels for each ID in custom profile fields
    /// </summary>
    public bool? IncludeLabels { get; init; }

    /// <summary>
    /// User to retrieve profile info for
    /// </summary>
    public string? User { get; init; }

    public required ContentType ContentType { get; init; }
}
