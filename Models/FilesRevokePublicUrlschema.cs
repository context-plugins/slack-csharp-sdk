using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from files.revokePublicURL method
/// </summary>
public record FilesRevokePublicUrlschema
{
    [JsonPropertyName("file")]
    public required Fileobject File { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
