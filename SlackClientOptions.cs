using System.Collections.Generic;
using Slack.Core.Authentication.OAuth2;
using Slack.Core.Authentication.OAuth2.AuthorizationCode;
using Slack.Core.Configuration;
using Slack.Core.Hooks;
using Slack.Servers;

namespace Slack;

public class SlackClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
    public IReadOnlyList<SdkHook> Hooks { get; set; } = [];
    public OAuth2AuthorizationCodeCredentials? SlackAuth { get; set; }
    public IOAuth2RefreshableTokenStrategy<OAuth2AuthorizationCodeCredentials>? SlackAuthTokenStrategy { get; set; }
}
