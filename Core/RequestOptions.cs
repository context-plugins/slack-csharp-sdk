using Microsoft.Extensions.Logging;

namespace Slack.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }
}
