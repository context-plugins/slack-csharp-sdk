using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Reminders;

/// <summary>
/// The inputs of the RemindersAdd operation.
/// </summary>
public sealed record RemindersAddRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>reminders:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// The content of the reminder
    /// </summary>
    public required string Text { get; init; }

    /// <summary>
    /// When this reminder should happen: the Unix timestamp (up to five years from now), the number of seconds until the reminder (if within 24 hours), or a natural language description (Ex. "in 15 minutes," or "every Thursday")
    /// </summary>
    public required string Time { get; init; }

    /// <summary>
    /// The user who will receive the reminder. If no user is specified, the reminder will go to user who created it.
    /// </summary>
    public string? User { get; init; }
}
