using System.Collections.Generic;
using System.Text.Json.Serialization;
using Slack.Core.Validation.Attributes;

namespace Slack.Models;

public record Profile
{
    [JsonPropertyName("fields")]
    [UniqueItems]
    public required IReadOnlyList<ObjsTeamProfileField> Fields { get; init; }
}
