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

public sealed class AdminInviteRequests
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AdminInviteRequests(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// admin_inviteRequests_approve
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.invites:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="inviteRequestId"></param>
    /// <param name="teamId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Approve a workspace invite request.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminInviteRequestsApprove(string token,
        ContentType contentType,
        string inviteRequestId,
        string? teamId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.inviteRequests.approve"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("invite_request_id", inviteRequestId),
                    new Param("team_id", teamId)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_inviteRequests_deny
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.invites:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="inviteRequestId"></param>
    /// <param name="teamId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deny a workspace invite request.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminInviteRequestsDeny(string token,
        ContentType contentType,
        string inviteRequestId,
        string? teamId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.inviteRequests.deny"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("invite_request_id", inviteRequestId),
                    new Param("team_id", teamId)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_inviteRequests_list
    /// </summary>
    /// <param name="teamId">ID for the workspace where the invite requests were made.</param>
    /// <param name="cursor">Value of the <c>next_cursor</c> field sent as part of the previous API response</param>
    /// <param name="limit">The number of results that will be returned by the API on each invocation. Must be between 1 - 1000, both inclusive</param>
    /// <param name="token">Authentication token. Requires scope: <c>admin.invites:read</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all pending workspace invite requests.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminInviteRequestsList(string? teamId,
        string? cursor,
        int? limit,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.inviteRequests.list"),
            [],
            [new Param("team_id", teamId), new Param("cursor", cursor), new Param("limit", limit)],
            [new HeaderParam("token", token), new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
