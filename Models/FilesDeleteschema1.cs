using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response files.delete method
/// </summary>
public record FilesDeleteschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
