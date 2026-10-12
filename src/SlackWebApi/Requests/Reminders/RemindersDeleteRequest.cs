using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Reminders;

/// <summary>
/// The inputs of the RemindersDelete operation.
/// </summary>
public sealed record RemindersDeleteRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>reminders:write</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// The ID of the reminder
    /// </summary>
    public string? Reminder { get; init; }
}
