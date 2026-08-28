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
    public SlackWebApiClient(HttpClient httpClient, SlackWebApiClientOptions options)
    {
        var server = new Server(options.Environment, options.Server);
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
        var rawClient =
            new RawClient(httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks);
        var auth = new AuthSchemes(options, server, rawClient, urlFactory);
        Admin = new Admin(rawClient, server, auth);
        AdminApps = new AdminApps(rawClient, server, auth);
        AdminAppsApproved = new AdminAppsApproved(rawClient, server, auth);
        AdminAppsRequests = new AdminAppsRequests(rawClient, server, auth);
        AdminAppsRestricted = new AdminAppsRestricted(rawClient, server, auth);
        AdminConversations = new AdminConversations(rawClient, server, auth);
        AdminConversationsEkm = new AdminConversationsEkm(rawClient, server, auth);
        AdminConversationsRestrictAccess = new AdminConversationsRestrictAccess(rawClient, server, auth);
        AdminEmoji = new AdminEmoji(rawClient, server, auth);
        AdminInviteRequests = new AdminInviteRequests(rawClient, server, auth);
        AdminInviteRequestsApproved = new AdminInviteRequestsApproved(rawClient, server, auth);
        AdminInviteRequestsDenied = new AdminInviteRequestsDenied(rawClient, server, auth);
        AdminTeams = new AdminTeams(rawClient, server, auth);
        AdminTeamsAdmins = new AdminTeamsAdmins(rawClient, server, auth);
        AdminTeamsOwners = new AdminTeamsOwners(rawClient, server, auth);
        AdminTeamsSettings = new AdminTeamsSettings(rawClient, server, auth);
        AdminUsergroups = new AdminUsergroups(rawClient, server, auth);
        AdminUsers = new AdminUsers(rawClient, server, auth);
        AdminUsersSession = new AdminUsersSession(rawClient, server, auth);
        ApiApi = new ApiApi(rawClient, server, auth);
        Apps = new Apps(rawClient, server, auth);
        AppsEventAuthorizations = new AppsEventAuthorizations(rawClient, server, auth);
        AppsPermissions = new AppsPermissions(rawClient, server, auth);
        AppsPermissionsResources = new AppsPermissionsResources(rawClient, server, auth);
        AppsPermissionsScopes = new AppsPermissionsScopes(rawClient, server, auth);
        AppsPermissionsUsers = new AppsPermissionsUsers(rawClient, server, auth);
        Auth = new Auth(rawClient, server, auth);
        Bots = new Bots(rawClient, server, auth);
        Calls = new Calls(rawClient, server, auth);
        CallsParticipants = new CallsParticipants(rawClient, server, auth);
        Chat = new Chat(rawClient, server, auth);
        ChatScheduledMessages = new ChatScheduledMessages(rawClient, server, auth);
        Conversations = new Conversations(rawClient, server, auth);
        Dialog = new Dialog(rawClient, server, auth);
        Dnd = new Dnd(rawClient, server, auth);
        Emoji = new Emoji(rawClient, server, auth);
        Files = new Files(rawClient, server, auth);
        FilesComments = new FilesComments(rawClient, server, auth);
        FilesRemote = new FilesRemote(rawClient, server, auth);
        Migration = new Migration(rawClient, server, auth);
        Oauth = new Oauth(rawClient, server, auth);
        OauthV2 = new OauthV2(rawClient, server, auth);
        Pins = new Pins(rawClient, server, auth);
        Reactions = new Reactions(rawClient, server, auth);
        Reminders = new Reminders(rawClient, server, auth);
        Rtm = new Rtm(rawClient, server, auth);
        Search = new Search(rawClient, server, auth);
        Stars = new Stars(rawClient, server, auth);
        TeamApi = new TeamApi(rawClient, server, auth);
        TeamProfile = new TeamProfile(rawClient, server, auth);
        Usergroups = new Usergroups(rawClient, server, auth);
        UsergroupsUsers = new UsergroupsUsers(rawClient, server, auth);
        Users = new Users(rawClient, server, auth);
        UsersProfile = new UsersProfile(rawClient, server, auth);
        Views = new Views(rawClient, server, auth);
        Workflows = new Workflows(rawClient, server, auth);
    }

    public Admin Admin { get; }

    public AdminApps AdminApps { get; }

    public AdminAppsApproved AdminAppsApproved { get; }

    public AdminAppsRequests AdminAppsRequests { get; }

    public AdminAppsRestricted AdminAppsRestricted { get; }

    public AdminConversations AdminConversations { get; }

    public AdminConversationsEkm AdminConversationsEkm { get; }

    public AdminConversationsRestrictAccess AdminConversationsRestrictAccess { get; }

    public AdminEmoji AdminEmoji { get; }

    public AdminInviteRequests AdminInviteRequests { get; }

    public AdminInviteRequestsApproved AdminInviteRequestsApproved { get; }

    public AdminInviteRequestsDenied AdminInviteRequestsDenied { get; }

    public AdminTeams AdminTeams { get; }

    public AdminTeamsAdmins AdminTeamsAdmins { get; }

    public AdminTeamsOwners AdminTeamsOwners { get; }

    public AdminTeamsSettings AdminTeamsSettings { get; }

    public AdminUsergroups AdminUsergroups { get; }

    public AdminUsers AdminUsers { get; }

    public AdminUsersSession AdminUsersSession { get; }

    public ApiApi ApiApi { get; }

    public Apps Apps { get; }

    public AppsEventAuthorizations AppsEventAuthorizations { get; }

    public AppsPermissions AppsPermissions { get; }

    public AppsPermissionsResources AppsPermissionsResources { get; }

    public AppsPermissionsScopes AppsPermissionsScopes { get; }

    public AppsPermissionsUsers AppsPermissionsUsers { get; }

    public Auth Auth { get; }

    public Bots Bots { get; }

    public Calls Calls { get; }

    public CallsParticipants CallsParticipants { get; }

    public Chat Chat { get; }

    public ChatScheduledMessages ChatScheduledMessages { get; }

    public Conversations Conversations { get; }

    public Dialog Dialog { get; }

    public Dnd Dnd { get; }

    public Emoji Emoji { get; }

    public Files Files { get; }

    public FilesComments FilesComments { get; }

    public FilesRemote FilesRemote { get; }

    public Migration Migration { get; }

    public Oauth Oauth { get; }

    public OauthV2 OauthV2 { get; }

    public Pins Pins { get; }

    public Reactions Reactions { get; }

    public Reminders Reminders { get; }

    public Rtm Rtm { get; }

    public Search Search { get; }

    public Stars Stars { get; }

    public TeamApi TeamApi { get; }

    public TeamProfile TeamProfile { get; }

    public Usergroups Usergroups { get; }

    public UsergroupsUsers UsergroupsUsers { get; }

    public Users Users { get; }

    public UsersProfile UsersProfile { get; }

    public Views Views { get; }

    public Workflows Workflows { get; }
}
