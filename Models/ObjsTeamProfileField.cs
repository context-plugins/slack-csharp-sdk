using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

public record ObjsTeamProfileField
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field_name")]
    public string? FieldName { get; init; }

    [JsonPropertyName("hint")]
    public required string Hint { get; init; }

    [JsonPropertyName("id")]
    [RegularExpression("^X[a-zA-Z0-9]{9,}$")]
    public required string Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_hidden")]
    public bool? IsHidden { get; init; }

    [JsonPropertyName("label")]
    public required string Label { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public object? Options { get; init; }

    [JsonPropertyName("ordering")]
    public required double Ordering { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("possible_values")]
    public IReadOnlyList<string?>? PossibleValues { get; init; }

    [JsonPropertyName("type")]
    public required TypeModel Type { get; init; }
}
