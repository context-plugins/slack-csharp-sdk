using System;
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

public sealed class Dnd
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Dnd(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// dnd_endDnd
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>dnd:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DndEndDndschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Ends the current user's Do Not Disturb session immediately.
    /// </remarks>
    public Task<DndEndDndschema> DndEndDnd(string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/dnd.endDnd"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<DndEndDndschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// dnd_endDnd
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>dnd:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DndEndDndschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Ends the current user's Do Not Disturb session immediately.
    /// </remarks>
    public Task<DndEndDndschema1> DndEndDnd1(string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/dnd.endDnd"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<DndEndDndschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// dnd_endSnooze
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>dnd:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DndEndSnoozeschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Ends the current user's snooze mode immediately.
    /// </remarks>
    public Task<DndEndSnoozeschema> DndEndSnooze(string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/dnd.endSnooze"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<DndEndSnoozeschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// dnd_endSnooze
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>dnd:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DndEndSnoozeschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Ends the current user's snooze mode immediately.
    /// </remarks>
    public Task<DndEndSnoozeschema1> DndEndSnooze1(string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/dnd.endSnooze"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<DndEndSnoozeschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// dnd_info
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>dnd:read</c></param>
    /// <param name="user">User to fetch status for (defaults to current user)</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DndInfoschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a user's current Do Not Disturb status.
    /// </remarks>
    public Task<DndInfoschema> DndInfo(string? token,
        string? user,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/dnd.info"),
            [],
            [new Param("token", token), new Param("user", user)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DndInfoschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// dnd_info
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>dnd:read</c></param>
    /// <param name="user">User to fetch status for (defaults to current user)</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DndInfoschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a user's current Do Not Disturb status.
    /// </remarks>
    public Task<DndInfoschema1> DndInfo1(string? token,
        string? user,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/dnd.info"),
            [],
            [new Param("token", token), new Param("user", user)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DndInfoschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// dnd_setSnooze
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="numMinutes"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DndSetSnoozeschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Turns on Do Not Disturb mode for the current user, or changes its duration.
    /// </remarks>
    public Task<DndSetSnoozeschema> DndSetSnooze(ContentType contentType,
        string token,
        string numMinutes,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/dnd.setSnooze"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token), new Param("num_minutes", numMinutes)]),
            JsonResponse.Create<DndSetSnoozeschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// dnd_setSnooze
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="numMinutes"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DndSetSnoozeschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Turns on Do Not Disturb mode for the current user, or changes its duration.
    /// </remarks>
    public Task<DndSetSnoozeschema1> DndSetSnooze1(ContentType contentType,
        string token,
        string numMinutes,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/dnd.setSnooze"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token), new Param("num_minutes", numMinutes)]),
            JsonResponse.Create<DndSetSnoozeschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// dnd_teamInfo
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>dnd:read</c></param>
    /// <param name="users">Comma-separated list of users to fetch Do Not Disturb status for</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the Do Not Disturb status for up to 50 users on a team.
    /// </remarks>
    public Task<Defaultsuccesstemplate> DndTeamInfo(string? token,
        string? users,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/dnd.teamInfo"),
            [],
            [new Param("token", token), new Param("users", users)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// dnd_teamInfo
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>dnd:read</c></param>
    /// <param name="users">Comma-separated list of users to fetch Do Not Disturb status for</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the Do Not Disturb status for up to 50 users on a team.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> DndTeamInfo1(string? token,
        string? users,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/dnd.teamInfo"),
            [],
            [new Param("token", token), new Param("users", users)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
