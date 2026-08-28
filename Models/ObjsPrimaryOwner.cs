using System.Text.Json.Serialization;
using Slack.Core.Models;

namespace Slack.Models;

public record ObjsPrimaryOwner
{
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
