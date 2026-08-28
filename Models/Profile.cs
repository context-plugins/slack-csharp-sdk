using System.Collections.Generic;
using System.Text.Json.Serialization;
using Slack.Core.Models;
using Slack.Core.Validation.Attributes;

namespace Slack.Models;

public record Profile
{
    [JsonPropertyName("fields")]
    [UniqueItems]
    public required IReadOnlyList<ObjsTeamProfileField> Fields { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
