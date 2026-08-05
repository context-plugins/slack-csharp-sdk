using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from dnd.endDnd method
/// </summary>
public record DndEndDndschema1
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
