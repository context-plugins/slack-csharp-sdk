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

public sealed class AppsEventAuthorizations
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AppsEventAuthorizations(RawClient rawClient, Server server, AuthSchemes auth)
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
}
