using Microsoft.Extensions.Logging;

namespace SlackWebApi.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }
}
