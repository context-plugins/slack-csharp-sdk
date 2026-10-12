using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using SlackWebApi.Core;
using SlackWebApi.Core.ErrorResponse;
using SlackWebApi.Core.Exceptions;
using SlackWebApi.Core.Models;
using SlackWebApi.Core.Request;
using SlackWebApi.Core.Response;
using SlackWebApi.Models;
using SlackWebApi.Requests.Apps;
using SlackWebApi.Requests.AppsEventAuthorizations;
using SlackWebApi.Requests.AppsPermissions;
using SlackWebApi.Requests.AppsPermissionsResources;
using SlackWebApi.Requests.AppsPermissionsScopes;
using SlackWebApi.Requests.AppsPermissionsUsers;

namespace SlackWebApi.Api;

public sealed class Apps
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Apps(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// apps_event_authorizations_list
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get a list of authorizations for the given event context. Each authorization represents an app installation that the event is visible to.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AppsEventAuthorizationsList(AppsEventAuthorizationsListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/apps.event.authorizations.list"),
            [],
            [
                new Param("event_context", request.EventContext),
                new Param("cursor", request.Cursor),
                new Param("limit", request.Limit),
            ],
            [new HeaderParam("token", request.Token), new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// apps_permissions_info
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AppsPermissionsInfoschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns list of permissions this app has on a team.
    /// </remarks>
    public Task<AppsPermissionsInfoschema> AppsPermissionsInfo(AppsPermissionsInfoRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/apps.permissions.info"),
            [],
            [new Param("token", request.Token)],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AppsPermissionsInfoschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// apps_permissions_request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AppsPermissionsRequestschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Allows an app to request additional scopes
    /// </remarks>
    public Task<AppsPermissionsRequestschema> AppsPermissionsRequest(AppsPermissionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/apps.permissions.request"),
            [],
            [
                new Param("token", request.Token),
                new Param("scopes", request.Scopes),
                new Param("trigger_id", request.TriggerId),
            ],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AppsPermissionsRequestschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// apps_permissions_resources_list
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AppsPermissionsResourcesListsuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns list of resource grants this app has on a team.
    /// </remarks>
    public Task<AppsPermissionsResourcesListsuccessschema> AppsPermissionsResourcesList(AppsPermissionsResourcesListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/apps.permissions.resources.list"),
            [],
            [new Param("token", request.Token), new Param("cursor", request.Cursor), new Param("limit", request.Limit)],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AppsPermissionsResourcesListsuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// apps_permissions_scopes_list
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiPermissionsScopesListsuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns list of scopes this app has on a team.
    /// </remarks>
    public Task<ApiPermissionsScopesListsuccessschema> AppsPermissionsScopesList(AppsPermissionsScopesListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/apps.permissions.scopes.list"),
            [],
            [new Param("token", request.Token)],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiPermissionsScopesListsuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// apps_permissions_users_list
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns list of user grants and corresponding scopes this app has on a team.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AppsPermissionsUsersList(AppsPermissionsUsersListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/apps.permissions.users.list"),
            [],
            [new Param("token", request.Token), new Param("cursor", request.Cursor), new Param("limit", request.Limit)],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// apps_permissions_users_request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enables an app to trigger a permissions modal to grant an app access to a user access scope.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AppsPermissionsUsersRequest(AppsPermissionsUsersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/apps.permissions.users.request"),
            [],
            [
                new Param("token", request.Token),
                new Param("scopes", request.Scopes),
                new Param("trigger_id", request.TriggerId),
                new Param("user", request.User),
            ],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// apps_uninstall
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AppsUninstallschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uninstalls your app from a workspace.
    /// </remarks>
    public Task<AppsUninstallschema> AppsUninstall(AppsUninstallRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/apps.uninstall"),
            [],
            [
                new Param("token", request.Token),
                new Param("client_id", request.ClientId),
                new Param("client_secret", request.ClientSecret),
            ],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AppsUninstallschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);
}
