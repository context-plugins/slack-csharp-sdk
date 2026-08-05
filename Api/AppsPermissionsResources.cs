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

public sealed class AppsPermissionsResources
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AppsPermissionsResources(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

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
}
