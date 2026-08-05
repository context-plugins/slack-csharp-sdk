using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response files.comments.delete method
/// </summary>
public record FilesCommentsDeleteschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
