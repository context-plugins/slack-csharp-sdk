using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from files.revokePublicURL method
/// </summary>
public record FilesRevokePublicUrlschema1
{
    [JsonPropertyName("file")]
    public required Fileobject File { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
