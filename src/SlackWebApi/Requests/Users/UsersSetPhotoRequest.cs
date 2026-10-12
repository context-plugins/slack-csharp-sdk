using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Users;

/// <summary>
/// The inputs of the UsersSetPhoto operation.
/// </summary>
public sealed record UsersSetPhotoRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>users.profile:write</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// Width/height of crop box (always square)
    /// </summary>
    public string? CropW { get; init; }

    /// <summary>
    /// X coordinate of top-left corner of crop box
    /// </summary>
    public string? CropX { get; init; }

    /// <summary>
    /// Y coordinate of top-left corner of crop box
    /// </summary>
    public string? CropY { get; init; }

    /// <summary>
    /// File contents via <c>multipart/form-data</c>.
    /// </summary>
    public string? Image { get; init; }
}
