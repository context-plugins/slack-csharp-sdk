using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Models;

public record FileCommentObject
{
    [JsonPropertyName("comment")]
    public required string Comment { get; init; }

    [JsonPropertyName("created")]
    public required int Created { get; init; }

    [JsonPropertyName("id")]
    [RegularExpression("^Fc[A-Z0-9]{8,}$")]
    public required string Id { get; init; }

    [JsonPropertyName("is_intro")]
    public required bool IsIntro { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_starred")]
    public bool? IsStarred { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_stars")]
    public int? NumStars { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pinned_info")]
    public object? PinnedInfo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pinned_to")]
    public IReadOnlyList<string>? PinnedTo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reactions")]
    public IReadOnlyList<Reactionobject>? Reactions { get; init; }

    [JsonPropertyName("timestamp")]
    public required int Timestamp { get; init; }

    [JsonPropertyName("user")]
    [RegularExpression("^[UW][A-Z0-9]{2,}$")]
    public required string User { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
