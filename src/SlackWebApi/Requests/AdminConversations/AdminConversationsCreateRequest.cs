using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminConversations;

/// <summary>
/// The inputs of the AdminConversationsCreate operation.
/// </summary>
public sealed record AdminConversationsCreateRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.conversations:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Name of the public or private channel to create.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// When <c>true</c>, creates a private channel instead of a public channel
    /// </summary>
    public required bool IsPrivate { get; init; }

    /// <summary>
    /// Description of the public or private channel to create.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    /// When <c>true</c>, the channel will be available org-wide. Note: if the channel is not <c>org_wide=true</c>, you must specify a <c>team_id</c> for this channel
    /// </summary>
    public bool? OrgWide { get; init; }

    /// <summary>
    /// The workspace to create the channel in. Note: this argument is required unless you set <c>org_wide=true</c>.
    /// </summary>
    public string? TeamId { get; init; }
}
