using Slack.Core;
using Slack.Core.Authentication;
using Slack.Core.Authentication.OAuth2;
using Slack.Core.Authentication.OAuth2.AuthorizationCode;

namespace Slack;

internal sealed class AuthSchemes
{
    public IAuthScheme SlackAuth { get; }

    public AuthSchemes(SlackClientOptions options, Server server, RawClient rawClient, UriFactory urlFactory)
    {
        SlackAuth =
            OAuth2RefreshableScheme<OAuth2AuthorizationCodeCredentials>.Create(options.SlackAuth,
                options.SlackAuthTokenStrategy ??
                    OAuth2AuthorizationCodeStrategy.ForBasicAuthRequest(server.Default("/authorize"),
                        server.Default("/oauth.access"),
                        rawClient,
                        urlFactory));
    }
}
