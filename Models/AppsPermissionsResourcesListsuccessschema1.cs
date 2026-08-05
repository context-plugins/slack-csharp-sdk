using System.Collections.Generic;
using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response apps.permissions.resources.list method
/// </summary>
public record AppsPermissionsResourcesListsuccessschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }

    [JsonPropertyName("resources")]
    public required IReadOnlyList<Resource> Resources { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response_metadata")]
    public ResponseMetadata? ResponseMetadata { get; init; }
}
