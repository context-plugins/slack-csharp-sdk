using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Views;

/// <summary>
/// The inputs of the ViewsUpdate operation.
/// </summary>
public sealed record ViewsUpdateRequest
{
    /// <summary>
    /// A unique identifier of the view to be updated. Either <c>view_id</c> or <c>external_id</c> is required.
    /// </summary>
    public string? ViewId { get; init; }

    /// <summary>
    /// A unique identifier of the view set by the developer. Must be unique for all views on a team. Max length of 255 characters. Either <c>view_id</c> or <c>external_id</c> is required.
    /// </summary>
    public string? ExternalId { get; init; }

    /// <summary>
    /// A <see href="/reference/surfaces/views">view object</see>. This must be a JSON-encoded string.
    /// </summary>
    public string? View { get; init; }

    /// <summary>
    /// A string that represents view state to protect against possible race conditions.
    /// </summary>
    public string? Hash { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>none</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }
}
