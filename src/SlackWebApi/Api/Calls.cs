using System;
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
using SlackWebApi.Requests.Calls;
using SlackWebApi.Requests.CallsParticipants;

namespace SlackWebApi.Api;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Registers a new Call.
    /// </remarks>
    public Task<Defaultsuccesstemplate> CallsAdd(CallsAddRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/calls.add"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("external_unique_id", request.ExternalUniqueId),
                new Param("join_url", request.JoinUrl),
                new Param("external_display_id", request.ExternalDisplayId),
                new Param("desktop_app_join_url", request.DesktopAppJoinUrl),
                new Param("date_start", request.DateStart),
                new Param("title", request.Title),
                new Param("created_by", request.CreatedBy),
                new Param("users", request.Users)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// calls_end
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Ends a Call.
    /// </remarks>
    public Task<Defaultsuccesstemplate> CallsEnd(CallsEndRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/calls.end"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("id", request.Id), new Param("duration", request.Duration)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// calls_info
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns information about a Call.
    /// </remarks>
    public Task<Defaultsuccesstemplate> CallsInfo(CallsInfoRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/calls.info"),
            [],
            [new Param("id", request.Id)],
            [new HeaderParam("token", request.Token), new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// calls_participants_add
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Registers new participants added to a Call.
    /// </remarks>
    public Task<Defaultsuccesstemplate> CallsParticipantsAdd(CallsParticipantsAddRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/calls.participants.add"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("id", request.Id), new Param("users", request.Users)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// calls_participants_remove
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Registers participants removed from a Call.
    /// </remarks>
    public Task<Defaultsuccesstemplate> CallsParticipantsRemove(CallsParticipantsRemoveRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/calls.participants.remove"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("id", request.Id), new Param("users", request.Users)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// calls_update
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates information about a Call.
    /// </remarks>
    public Task<Defaultsuccesstemplate> CallsUpdate(CallsUpdateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/calls.update"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("id", request.Id),
                new Param("title", request.Title),
                new Param("join_url", request.JoinUrl),
                new Param("desktop_app_join_url", request.DesktopAppJoinUrl)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);
}
