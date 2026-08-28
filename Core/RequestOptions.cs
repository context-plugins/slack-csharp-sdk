using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using SlackWebApi.Core.Hooks;

namespace SlackWebApi.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
