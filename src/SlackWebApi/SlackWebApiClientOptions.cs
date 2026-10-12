using System;
using System.Collections.Generic;
using SlackWebApi.Core.Authentication.OAuth2;
using SlackWebApi.Core.Authentication.OAuth2.AuthorizationCode;
using SlackWebApi.Core.Configuration;
using SlackWebApi.Core.Hooks;
using SlackWebApi.Servers;

namespace SlackWebApi;

public class SlackWebApiClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public TimeProvider TimeProvider { get; set; } = TimeProvider.System;
    public ServerOptions Server { get; set; } = new();
    /// <summary>
    /// Maximum time to wait for the next frame of a streaming (SSE) response before the stream is
    /// torn down with a timeout. Bounds only the wait for the server between frames, never the
    /// caller's own processing time. Set to null to wait indefinitely.
    /// </summary>
    public TimeSpan? StreamReadTimeout { get; set; } = TimeSpan.FromSeconds(60);
    public IReadOnlyList<SdkHook> Hooks { get; set; } = [];
    public OAuth2AuthorizationCodeCredentials? SlackAuth { get; set; }
    public IOAuth2RefreshableTokenStrategy<OAuth2AuthorizationCodeCredentials>? SlackAuthTokenStrategy { get; set; }
}
