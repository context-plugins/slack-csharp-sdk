using System.Collections.Generic;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Validation.Attributes;

namespace SlackWebApi.Models;

public record Profile
{
    [JsonPropertyName("fields")]
    [UniqueItems]
    public required IReadOnlyList<ObjsTeamProfileField> Fields { get; init; }
}
