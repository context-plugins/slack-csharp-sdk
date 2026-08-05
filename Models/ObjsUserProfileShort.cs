using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Slack.Models;

public record ObjsUserProfileShort
{
    [JsonPropertyName("avatar_hash")]
    public required string AvatarHash { get; init; }

    [JsonPropertyName("display_name")]
    public required string DisplayName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("display_name_normalized")]
    public string? DisplayNameNormalized { get; init; }

    [JsonPropertyName("first_name")]
    public required string? FirstName { get; init; }

    [JsonPropertyName("image_72")]
    public required string Image72 { get; init; }

    [JsonPropertyName("is_restricted")]
    public required bool IsRestricted { get; init; }

    [JsonPropertyName("is_ultra_restricted")]
    public required bool IsUltraRestricted { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("real_name")]
    public required string RealName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("real_name_normalized")]
    public string? RealNameNormalized { get; init; }

    [JsonPropertyName("team")]
    [RegularExpression("^[TE][A-Z0-9]{8,}$")]
    public required string Team { get; init; }
}
