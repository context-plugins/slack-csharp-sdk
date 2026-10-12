using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.UsersProfile;

/// <summary>
/// The inputs of the UsersProfileSet operation.
/// </summary>
public sealed record UsersProfileSetRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>users.profile:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Name of a single key to set. Usable only if <c>profile</c> is not passed.
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// Collection of key:value pairs presented as a URL-encoded JSON hash. At most 50 fields may be set. Each field name is limited to 255 characters.
    /// </summary>
    public string? Profile { get; init; }

    /// <summary>
    /// ID of user to change. This argument may only be specified by team admins on paid teams.
    /// </summary>
    public string? User { get; init; }

    /// <summary>
    /// Value to set a single key to. Usable only if <c>profile</c> is not passed.
    /// </summary>
    public string? Value { get; init; }
}
