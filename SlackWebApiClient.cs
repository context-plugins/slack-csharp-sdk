using System.Net.Http;
using SlackWebApi.Api;
using SlackWebApi.Core;
using SlackWebApi.Core.Logging;
using SlackWebApi.Core.Models;

namespace SlackWebApi;

/// <summary>
/// One way to interact with the Slack platform is its HTTP RPC-based Web API, a collection of methods requiring OAuth 2.0-based user, bot, or workspace tokens blessed with related OAuth scopes.
/// </summary>
public sealed class SlackWebApiClient
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    public SlackWebApiClient(HttpClient httpClient, SlackWebApiClientOptions options)
    {
        _server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory =
            new HeadersFactory([new HeaderParam("User-Agent", "SlackWebApiClient/1.7.0 CSharp"),
                    new HeaderParam("X-APIMatic-Lang", "CSharp"),
                    new HeaderParam("X-APIMatic-Package-Version", "1.7.0"),
                    new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
                    new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
                    new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime)]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry);
        var httpLogger = new HttpLogger(options.Logging, "SlackWebApiClient");
        _rawClient =
            new RawClient(httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks);
        _auth = new AuthSchemes(options, _server, _rawClient, urlFactory);
    }

    public Admin Admin => field ??= new Admin(_rawClient, _server, _auth);

    public AdminApps AdminApps => field ??= new AdminApps(_rawClient, _server, _auth);

    public AdminAppsApproved AdminAppsApproved => field ??= new AdminAppsApproved(_rawClient, _server, _auth);

    public AdminAppsRequests AdminAppsRequests => field ??= new AdminAppsRequests(_rawClient, _server, _auth);

    public AdminAppsRestricted AdminAppsRestricted =>
        field ??= new AdminAppsRestricted(_rawClient, _server, _auth);

    public AdminConversations AdminConversations =>
        field ??= new AdminConversations(_rawClient, _server, _auth);

    public AdminConversationsEkm AdminConversationsEkm =>
        field ??= new AdminConversationsEkm(_rawClient, _server, _auth);

    public AdminConversationsRestrictAccess AdminConversationsRestrictAccess =>
        field ??= new AdminConversationsRestrictAccess(_rawClient, _server, _auth);

    public AdminEmoji AdminEmoji => field ??= new AdminEmoji(_rawClient, _server, _auth);

    public AdminInviteRequests AdminInviteRequests =>
        field ??= new AdminInviteRequests(_rawClient, _server, _auth);

    public AdminInviteRequestsApproved AdminInviteRequestsApproved =>
        field ??= new AdminInviteRequestsApproved(_rawClient, _server, _auth);

    public AdminInviteRequestsDenied AdminInviteRequestsDenied =>
        field ??= new AdminInviteRequestsDenied(_rawClient, _server, _auth);

    public AdminTeams AdminTeams => field ??= new AdminTeams(_rawClient, _server, _auth);

    public AdminTeamsAdmins AdminTeamsAdmins => field ??= new AdminTeamsAdmins(_rawClient, _server, _auth);

    public AdminTeamsOwners AdminTeamsOwners => field ??= new AdminTeamsOwners(_rawClient, _server, _auth);

    public AdminTeamsSettings AdminTeamsSettings =>
        field ??= new AdminTeamsSettings(_rawClient, _server, _auth);

    public AdminUsergroups AdminUsergroups => field ??= new AdminUsergroups(_rawClient, _server, _auth);

    public AdminUsers AdminUsers => field ??= new AdminUsers(_rawClient, _server, _auth);

    public AdminUsersSession AdminUsersSession => field ??= new AdminUsersSession(_rawClient, _server, _auth);

    public ApiApi ApiApi => field ??= new ApiApi(_rawClient, _server, _auth);

    public Apps Apps => field ??= new Apps(_rawClient, _server, _auth);

    public AppsEventAuthorizations AppsEventAuthorizations =>
        field ??= new AppsEventAuthorizations(_rawClient, _server, _auth);

    public AppsPermissions AppsPermissions => field ??= new AppsPermissions(_rawClient, _server, _auth);

    public AppsPermissionsResources AppsPermissionsResources =>
        field ??= new AppsPermissionsResources(_rawClient, _server, _auth);

    public AppsPermissionsScopes AppsPermissionsScopes =>
        field ??= new AppsPermissionsScopes(_rawClient, _server, _auth);

    public AppsPermissionsUsers AppsPermissionsUsers =>
        field ??= new AppsPermissionsUsers(_rawClient, _server, _auth);

    public Auth Auth => field ??= new Auth(_rawClient, _server, _auth);

    public Bots Bots => field ??= new Bots(_rawClient, _server, _auth);

    public Calls Calls => field ??= new Calls(_rawClient, _server, _auth);

    public CallsParticipants CallsParticipants => field ??= new CallsParticipants(_rawClient, _server, _auth);

    public Chat Chat => field ??= new Chat(_rawClient, _server, _auth);

    public ChatScheduledMessages ChatScheduledMessages =>
        field ??= new ChatScheduledMessages(_rawClient, _server, _auth);

    public Conversations Conversations => field ??= new Conversations(_rawClient, _server, _auth);

    public Dialog Dialog => field ??= new Dialog(_rawClient, _server, _auth);

    public Dnd Dnd => field ??= new Dnd(_rawClient, _server, _auth);

    public Emoji Emoji => field ??= new Emoji(_rawClient, _server, _auth);

    public Files Files => field ??= new Files(_rawClient, _server, _auth);

    public FilesComments FilesComments => field ??= new FilesComments(_rawClient, _server, _auth);

    public FilesRemote FilesRemote => field ??= new FilesRemote(_rawClient, _server, _auth);

    public Migration Migration => field ??= new Migration(_rawClient, _server, _auth);

    public Oauth Oauth => field ??= new Oauth(_rawClient, _server, _auth);

    public OauthV2 OauthV2 => field ??= new OauthV2(_rawClient, _server, _auth);

    public Pins Pins => field ??= new Pins(_rawClient, _server, _auth);

    public Reactions Reactions => field ??= new Reactions(_rawClient, _server, _auth);

    public Reminders Reminders => field ??= new Reminders(_rawClient, _server, _auth);

    public Rtm Rtm => field ??= new Rtm(_rawClient, _server, _auth);

    public Search Search => field ??= new Search(_rawClient, _server, _auth);

    public Stars Stars => field ??= new Stars(_rawClient, _server, _auth);

    public TeamApi TeamApi => field ??= new TeamApi(_rawClient, _server, _auth);

    public TeamProfile TeamProfile => field ??= new TeamProfile(_rawClient, _server, _auth);

    public Usergroups Usergroups => field ??= new Usergroups(_rawClient, _server, _auth);

    public UsergroupsUsers UsergroupsUsers => field ??= new UsergroupsUsers(_rawClient, _server, _auth);

    public Users Users => field ??= new Users(_rawClient, _server, _auth);

    public UsersProfile UsersProfile => field ??= new UsersProfile(_rawClient, _server, _auth);

    public Views Views => field ??= new Views(_rawClient, _server, _auth);

    public Workflows Workflows => field ??= new Workflows(_rawClient, _server, _auth);
}
