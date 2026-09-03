using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Models;

public record Profile1
{
    [JsonPropertyName("avatar_hash")]
    [RegularExpression("^[0-9a-f]{12}$")]
    public required string AvatarHash { get; init; }

    [JsonPropertyName("image_1024")]
    public required string Image1024 { get; init; }

    [JsonPropertyName("image_192")]
    public required string Image192 { get; init; }

    [JsonPropertyName("image_24")]
    public required string Image24 { get; init; }

    [JsonPropertyName("image_32")]
    public required string Image32 { get; init; }

    [JsonPropertyName("image_48")]
    public required string Image48 { get; init; }

    [JsonPropertyName("image_512")]
    public required string Image512 { get; init; }

    [JsonPropertyName("image_72")]
    public required string Image72 { get; init; }

    [JsonPropertyName("image_original")]
    public required string ImageOriginal { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
