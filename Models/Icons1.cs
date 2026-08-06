using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

public record Icons1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("emoji")]
    public string? Emoji { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("image_64")]
    public string? Image64 { get; init; }
}
