using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

public record Icons
{
    [JsonPropertyName("image_36")]
    public required string Image36 { get; init; }

    [JsonPropertyName("image_48")]
    public required string Image48 { get; init; }

    [JsonPropertyName("image_72")]
    public required string Image72 { get; init; }
}
