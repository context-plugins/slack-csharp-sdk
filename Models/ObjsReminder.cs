using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Slack.Models;

public record ObjsReminder
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("complete_ts")]
    public int? CompleteTs { get; init; }

    [JsonPropertyName("creator")]
    [RegularExpression("^[UW][A-Z0-9]{2,}$")]
    public required string Creator { get; init; }

    [JsonPropertyName("id")]
    [RegularExpression("^Rm[A-Z0-9]{8,}$")]
    public required string Id { get; init; }

    [JsonPropertyName("recurring")]
    public required bool Recurring { get; init; }

    [JsonPropertyName("text")]
    public required string Text { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("time")]
    public int? Time { get; init; }

    [JsonPropertyName("user")]
    [RegularExpression("^[UW][A-Z0-9]{2,}$")]
    public required string User { get; init; }
}
