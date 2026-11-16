using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using SlackWebApi.Core.Hooks;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<HeaderParam>? Headers { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
