using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response files.delete method
/// </summary>
public record FilesDeleteschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
