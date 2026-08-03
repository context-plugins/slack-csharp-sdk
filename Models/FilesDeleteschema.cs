using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response files.delete method
/// </summary>
public record FilesDeleteschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
