using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Slack.Models;

public record Message
{
    [JsonPropertyName("bot_id")]
    [RegularExpression("^B[A-Z0-9]{8,}$")]
    public required string BotId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bot_profile")]
    public BotProfileObject? BotProfile { get; init; }

    [JsonPropertyName("team")]
    [RegularExpression("^[T][A-Z0-9]{2,}$")]
    public required string Team { get; init; }

    [JsonPropertyName("text")]
    public required string Text { get; init; }

    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("user")]
    [RegularExpression("^[UW][A-Z0-9]{2,}$")]
    public required string User { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("username")]
    public string? Username { get; init; }
}
