using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Slack.Core.Validation.Attributes;

namespace Slack.Models;

public record Responsemetadata3
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    [MinLength(1)]
    [UniqueItems]
    public IReadOnlyList<string>? Warnings { get; init; }
}
