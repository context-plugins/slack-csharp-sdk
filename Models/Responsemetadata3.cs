using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;
using SlackWebApi.Core.Validation.Attributes;

namespace SlackWebApi.Models;

public record Responsemetadata3
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    [MinLength(1)]
    [UniqueItems]
    public IReadOnlyList<string>? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
