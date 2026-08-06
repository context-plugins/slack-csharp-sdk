using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

public record ScheduledMessage
{
    [JsonPropertyName("channel_id")]
    [RegularExpression("^[C][A-Z0-9]{2,}$")]
    public required string ChannelId { get; init; }

    [JsonPropertyName("date_created")]
    public required int DateCreated { get; init; }

    [JsonPropertyName("id")]
    [RegularExpression("^[Q][A-Z0-9]{8,}$")]
    public required string Id { get; init; }

    [JsonPropertyName("post_at")]
    public required int PostAt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("text")]
    public string? Text { get; init; }
}
