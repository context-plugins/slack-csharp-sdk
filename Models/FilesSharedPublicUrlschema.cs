using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from files.sharedPublicURL method
/// </summary>
public record FilesSharedPublicUrlschema
{
    [JsonPropertyName("file")]
    public required Fileobject File { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
