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

public sealed class Calls
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Calls(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// calls_add
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>calls:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="externalUniqueId"></param>
    /// <param name="joinUrl"></param>
    /// <param name="externalDisplayId"></param>
    /// <param name="desktopAppJoinUrl"></param>
    /// <param name="dateStart"></param>
    /// <param name="title"></param>
    /// <param name="createdBy"></param>
    /// <param name="users"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Registers a new Call.
    /// </remarks>
    public Task<Defaultsuccesstemplate> CallsAdd(string token,
        ContentType contentType,
        string externalUniqueId,
        string joinUrl,
        string? externalDisplayId,
        string? desktopAppJoinUrl,
        int? dateStart,
        string? title,
        string? createdBy,
        string? users,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/calls.add"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("external_unique_id", externalUniqueId),
                    new Param("join_url", joinUrl),
                    new Param("external_display_id", externalDisplayId),
                    new Param("desktop_app_join_url", desktopAppJoinUrl),
                    new Param("date_start", dateStart),
                    new Param("title", title),
                    new Param("created_by", createdBy),
                    new Param("users", users)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// calls_end
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>calls:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="id"></param>
    /// <param name="duration"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Ends a Call.
    /// </remarks>
    public Task<Defaultsuccesstemplate> CallsEnd(string token,
        ContentType contentType,
        string id,
        int? duration,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/calls.end"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("id", id), new Param("duration", duration)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// calls_info
    /// </summary>
    /// <param name="id"><c>id</c> of the Call returned by the <see href="/methods/calls.add"><c>calls.add</c></see> method.</param>
    /// <param name="token">Authentication token. Requires scope: <c>calls:read</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns information about a Call.
    /// </remarks>
    public Task<Defaultsuccesstemplate> CallsInfo(string id,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/calls.info"),
            [],
            [new Param("id", id)],
            [new HeaderParam("token", token), new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// calls_participants_add
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>calls:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="id"></param>
    /// <param name="users"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Registers new participants added to a Call.
    /// </remarks>
    public Task<Defaultsuccesstemplate> CallsParticipantsAdd(string token,
        ContentType contentType,
        string id,
        string users,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/calls.participants.add"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("id", id), new Param("users", users)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// calls_participants_remove
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>calls:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="id"></param>
    /// <param name="users"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Registers participants removed from a Call.
    /// </remarks>
    public Task<Defaultsuccesstemplate> CallsParticipantsRemove(string token,
        ContentType contentType,
        string id,
        string users,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/calls.participants.remove"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("id", id), new Param("users", users)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// calls_update
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>calls:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="id"></param>
    /// <param name="title"></param>
    /// <param name="joinUrl"></param>
    /// <param name="desktopAppJoinUrl"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates information about a Call.
    /// </remarks>
    public Task<Defaultsuccesstemplate> CallsUpdate(string token,
        ContentType contentType,
        string id,
        string? title,
        string? joinUrl,
        string? desktopAppJoinUrl,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/calls.update"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("id", id),
                    new Param("title", title),
                    new Param("join_url", joinUrl),
                    new Param("desktop_app_join_url", desktopAppJoinUrl)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
