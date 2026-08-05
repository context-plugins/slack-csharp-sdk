using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from files.sharedPublicURL method
/// </summary>
public record FilesSharedPublicUrlschema1
{
    [JsonPropertyName("file")]
    public required Fileobject File { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
