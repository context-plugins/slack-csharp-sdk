using System.Text.Json.Serialization;

namespace Slack.Models;

public record ObjsPrimaryOwner
{
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("id")]
    public required string Id { get; init; }
}
