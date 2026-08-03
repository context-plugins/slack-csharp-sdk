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
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Api;

public sealed class AppsPermissionsUsers
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AppsPermissionsUsers(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

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
}
