using SlackWebApi.Core;
using SlackWebApi.Core.Authentication;
using SlackWebApi.Core.Authentication.OAuth2;
using SlackWebApi.Core.Authentication.OAuth2.AuthorizationCode;

namespace SlackWebApi;

internal sealed class AuthSchemes
{
    public IAuthScheme SlackAuth { get; }

    public AuthSchemes(SlackWebApiClientOptions options, Server server, RawClient rawClient, UriFactory urlFactory)
    {
        SlackAuth =
            OAuth2RefreshableScheme<OAuth2AuthorizationCodeCredentials>.Create(
                options.SlackAuth,
                options.SlackAuthTokenStrategy ??
                    OAuth2AuthorizationCodeStrategy.ForBasicAuthRequest(
                        server.Default("/authorize"),
                        server.Default("/oauth.access"),
                        rawClient,
                        urlFactory),
                options.TimeProvider);
    }
}
