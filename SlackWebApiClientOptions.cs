using SlackWebApi.Core.Authentication.OAuth2;
using SlackWebApi.Core.Authentication.OAuth2.AuthorizationCode;
using SlackWebApi.Core.Configuration;
using SlackWebApi.Servers;

namespace SlackWebApi;

public class SlackWebApiClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
    public OAuth2AuthorizationCodeCredentials? SlackAuth { get; set; }
    public IOAuth2RefreshableTokenStrategy<OAuth2AuthorizationCodeCredentials>? SlackAuthTokenStrategy { get; set; }
}
