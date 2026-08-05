using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from dnd.setSnooze method
/// </summary>
public record DndSetSnoozeschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("snooze_enabled")]
    public required bool SnoozeEnabled { get; init; }

    [JsonPropertyName("snooze_endtime")]
    public required int SnoozeEndtime { get; init; }

    [JsonPropertyName("snooze_remaining")]
    public required int SnoozeRemaining { get; init; }
}
