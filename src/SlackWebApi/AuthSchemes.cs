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
                "SlackAuth",
                options.SlackAuth,
                OAuth2AuthorizationCodeStrategy.ForBasicAuthRequest(
                    server.AuthServer("/authorize"),
                    server.Default("/oauth.v2.access"),
                    rawClient,
                    urlFactory),
                options.TimeProvider,
                scope: "admin admin.apps:read admin.apps:write admin.conversations:read admin.conversations:write admin.invites:read admin.invites:write admin.teams:read admin.teams:write admin.usergroups:read admin.usergroups:write admin.users:read admin.users:write authorizations:read bot calls:read calls:write channels:history channels:manage channels:read channels:write chat:write chat:write:bot chat:write:user conversations:history conversations:read conversations:write dnd:read dnd:write emoji:read files:read files:write:user groups:history groups:read groups:write identity.basic im:history im:read im:write links:write mpim:history mpim:read mpim:write none pins:read pins:write reactions:read reactions:write reminders:read reminders:write remote_files:read remote_files:share remote_files:write rtm:stream search:read stars:read stars:write team:read tokens.basic usergroups:read usergroups:write users.profile:read users.profile:write users:read users:read.email users:write workflow.steps:execute");
    }
}
