using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response files.comments.delete method
/// </summary>
public record FilesCommentsDeleteschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
