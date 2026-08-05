using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from dnd.info method
/// </summary>
public record DndInfoschema1
{
    [JsonPropertyName("dnd_enabled")]
    public required bool DndEnabled { get; init; }

    [JsonPropertyName("next_dnd_end_ts")]
    public required int NextDndEndTs { get; init; }

    [JsonPropertyName("next_dnd_start_ts")]
    public required int NextDndStartTs { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("snooze_enabled")]
    public bool? SnoozeEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("snooze_endtime")]
    public int? SnoozeEndtime { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("snooze_remaining")]
    public int? SnoozeRemaining { get; init; }
}
