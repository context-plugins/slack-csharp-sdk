using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Slack.Core;
using Slack.Core.ErrorResponse;
using Slack.Core.Exceptions;
using Slack.Core.Models;
using Slack.Core.Request;
using Slack.Core.Response;
using Slack.Models;
using Slack.Models.Enums;

namespace Slack.Api;

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
    /// <param name="eventContext"></param>
    /// <param name="cursor"></param>
    /// <param name="limit"></param>
    /// <param name="token">Authentication token. Requires scope: <c>authorizations:read</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get a list of authorizations for the given event context. Each authorization represents an app installation that the event is visible to.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AppsEventAuthorizationsList(string eventContext,
        string? cursor,
        int? limit,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/apps.event.authorizations.list"),
            [],
            [new Param("event_context", eventContext), new Param("cursor", cursor), new Param("limit", limit)],
            [new HeaderParam("token", token), new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// apps_event_authorizations_list
    /// </summary>
    /// <param name="eventContext"></param>
    /// <param name="cursor"></param>
    /// <param name="limit"></param>
    /// <param name="token">Authentication token. Requires scope: <c>authorizations:read</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get a list of authorizations for the given event context. Each authorization represents an app installation that the event is visible to.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AppsEventAuthorizationsList1(string eventContext,
        string? cursor,
        int? limit,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/apps.event.authorizations.list"),
            [],
            [new Param("event_context", eventContext), new Param("cursor", cursor), new Param("limit", limit)],
            [new HeaderParam("token", token), new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// apps_permissions_info
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>none</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AppsPermissionsInfoschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns list of permissions this app has on a team.
    /// </remarks>
    public Task<AppsPermissionsInfoschema> AppsPermissionsInfo(string? token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/apps.permissions.info"),
            [],
            [new Param("token", token)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AppsPermissionsInfoschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// apps_permissions_info
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>none</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AppsPermissionsInfoschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns list of permissions this app has on a team.
    /// </remarks>
    public Task<AppsPermissionsInfoschema1> AppsPermissionsInfo1(string? token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/apps.permissions.info"),
            [],
            [new Param("token", token)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AppsPermissionsInfoschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// apps_permissions_request
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>none</c></param>
    /// <param name="scopes">A comma separated list of scopes to request for</param>
    /// <param name="triggerId">Token used to trigger the permissions API</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AppsPermissionsRequestschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Allows an app to request additional scopes
    /// </remarks>
    public Task<AppsPermissionsRequestschema> AppsPermissionsRequest(string token,
        string scopes,
        string triggerId,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/apps.permissions.request"),
            [],
            [new Param("token", token), new Param("scopes", scopes), new Param("trigger_id", triggerId)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AppsPermissionsRequestschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// apps_permissions_request
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>none</c></param>
    /// <param name="scopes">A comma separated list of scopes to request for</param>
    /// <param name="triggerId">Token used to trigger the permissions API</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AppsPermissionsRequestschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Allows an app to request additional scopes
    /// </remarks>
    public Task<AppsPermissionsRequestschema1> AppsPermissionsRequest1(string token,
        string scopes,
        string triggerId,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/apps.permissions.request"),
            [],
            [new Param("token", token), new Param("scopes", scopes), new Param("trigger_id", triggerId)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AppsPermissionsRequestschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// apps_permissions_resources_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>none</c></param>
    /// <param name="cursor">Paginate through collections of data by setting the <c>cursor</c> parameter to a <c>next_cursor</c> attribute returned by a previous request's <c>response_metadata</c>. Default value fetches the first "page" of the collection.</param>
    /// <param name="limit">The maximum number of items to return.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AppsPermissionsResourcesListsuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns list of resource grants this app has on a team.
    /// </remarks>
    public Task<AppsPermissionsResourcesListsuccessschema> AppsPermissionsResourcesList(string token,
        string? cursor,
        int? limit,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/apps.permissions.resources.list"),
            [],
            [new Param("token", token), new Param("cursor", cursor), new Param("limit", limit)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AppsPermissionsResourcesListsuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// apps_permissions_resources_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>none</c></param>
    /// <param name="cursor">Paginate through collections of data by setting the <c>cursor</c> parameter to a <c>next_cursor</c> attribute returned by a previous request's <c>response_metadata</c>. Default value fetches the first "page" of the collection.</param>
    /// <param name="limit">The maximum number of items to return.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AppsPermissionsResourcesListsuccessschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns list of resource grants this app has on a team.
    /// </remarks>
    public Task<AppsPermissionsResourcesListsuccessschema1> AppsPermissionsResourcesList1(string token,
        string? cursor,
        int? limit,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/apps.permissions.resources.list"),
            [],
            [new Param("token", token), new Param("cursor", cursor), new Param("limit", limit)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AppsPermissionsResourcesListsuccessschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// apps_permissions_scopes_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>none</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiPermissionsScopesListsuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns list of scopes this app has on a team.
    /// </remarks>
    public Task<ApiPermissionsScopesListsuccessschema> AppsPermissionsScopesList(string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/apps.permissions.scopes.list"),
            [],
            [new Param("token", token)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiPermissionsScopesListsuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// apps_permissions_scopes_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>none</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiPermissionsScopesListsuccessschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns list of scopes this app has on a team.
    /// </remarks>
    public Task<ApiPermissionsScopesListsuccessschema1> AppsPermissionsScopesList1(string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/apps.permissions.scopes.list"),
            [],
            [new Param("token", token)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiPermissionsScopesListsuccessschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// apps_permissions_users_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>none</c></param>
    /// <param name="cursor">Paginate through collections of data by setting the <c>cursor</c> parameter to a <c>next_cursor</c> attribute returned by a previous request's <c>response_metadata</c>. Default value fetches the first "page" of the collection.</param>
    /// <param name="limit">The maximum number of items to return.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns list of user grants and corresponding scopes this app has on a team.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AppsPermissionsUsersList(string token,
        string? cursor,
        int? limit,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/apps.permissions.users.list"),
            [],
            [new Param("token", token), new Param("cursor", cursor), new Param("limit", limit)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// apps_permissions_users_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>none</c></param>
    /// <param name="cursor">Paginate through collections of data by setting the <c>cursor</c> parameter to a <c>next_cursor</c> attribute returned by a previous request's <c>response_metadata</c>. Default value fetches the first "page" of the collection.</param>
    /// <param name="limit">The maximum number of items to return.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns list of user grants and corresponding scopes this app has on a team.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AppsPermissionsUsersList1(string token,
        string? cursor,
        int? limit,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/apps.permissions.users.list"),
            [],
            [new Param("token", token), new Param("cursor", cursor), new Param("limit", limit)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// apps_permissions_users_request
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>none</c></param>
    /// <param name="scopes">A comma separated list of user scopes to request for</param>
    /// <param name="triggerId">Token used to trigger the request</param>
    /// <param name="user">The user this scope is being requested for</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enables an app to trigger a permissions modal to grant an app access to a user access scope.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AppsPermissionsUsersRequest(string token,
        string scopes,
        string triggerId,
        string user,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/apps.permissions.users.request"),
            [],
            [new Param("token", token),
                new Param("scopes", scopes),
                new Param("trigger_id", triggerId),
                new Param("user", user)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// apps_permissions_users_request
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>none</c></param>
    /// <param name="scopes">A comma separated list of user scopes to request for</param>
    /// <param name="triggerId">Token used to trigger the request</param>
    /// <param name="user">The user this scope is being requested for</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enables an app to trigger a permissions modal to grant an app access to a user access scope.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AppsPermissionsUsersRequest1(string token,
        string scopes,
        string triggerId,
        string user,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/apps.permissions.users.request"),
            [],
            [new Param("token", token),
                new Param("scopes", scopes),
                new Param("trigger_id", triggerId),
                new Param("user", user)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// apps_uninstall
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>none</c></param>
    /// <param name="clientId">Issued when you created your application.</param>
    /// <param name="clientSecret">Issued when you created your application.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AppsUninstallschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uninstalls your app from a workspace.
    /// </remarks>
    public Task<AppsUninstallschema> AppsUninstall(string? token,
        string? clientId,
        string? clientSecret,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/apps.uninstall"),
            [],
            [new Param("token", token), new Param("client_id", clientId), new Param("client_secret", clientSecret)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AppsUninstallschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// apps_uninstall
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>none</c></param>
    /// <param name="clientId">Issued when you created your application.</param>
    /// <param name="clientSecret">Issued when you created your application.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AppsUninstallschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uninstalls your app from a workspace.
    /// </remarks>
    public Task<AppsUninstallschema1> AppsUninstall1(string? token,
        string? clientId,
        string? clientSecret,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/apps.uninstall"),
            [],
            [new Param("token", token), new Param("client_id", clientId), new Param("client_secret", clientSecret)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AppsUninstallschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
