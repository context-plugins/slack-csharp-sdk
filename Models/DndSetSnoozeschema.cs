using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from dnd.setSnooze method
/// </summary>
public record DndSetSnoozeschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("snooze_enabled")]
    public required bool SnoozeEnabled { get; init; }

    [JsonPropertyName("snooze_endtime")]
    public required int SnoozeEndtime { get; init; }

    [JsonPropertyName("snooze_remaining")]
    public required int SnoozeRemaining { get; init; }
}
