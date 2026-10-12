using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminConversationsEkm;

/// <summary>
/// The inputs of the AdminConversationsEkmListOriginalConnectedChannelInfo operation.
/// </summary>
public sealed record AdminConversationsEkmListOriginalConnectedChannelInfoRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.conversations:read</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// A comma-separated list of channels to filter to.
    /// </summary>
    public string? ChannelIds { get; init; }

    /// <summary>
    /// A comma-separated list of the workspaces to which the channels you would like returned belong.
    /// </summary>
    public string? TeamIds { get; init; }

    /// <summary>
    /// The maximum number of items to return. Must be between 1 - 1000 both inclusive.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page.
    /// </summary>
    public string? Cursor { get; init; }

    public required ContentType ContentType { get; init; }
}
