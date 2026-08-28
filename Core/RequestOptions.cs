using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Slack.Core.Hooks;

namespace Slack.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
