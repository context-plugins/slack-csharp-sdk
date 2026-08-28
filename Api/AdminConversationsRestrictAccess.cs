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

public sealed class AdminConversationsRestrictAccess
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AdminConversationsRestrictAccess(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// admin_conversations_restrictAccess_addGroup
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="groupId"></param>
    /// <param name="channelId"></param>
    /// <param name="teamId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Add an allowlist of IDP groups for accessing a channel
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminConversationsRestrictAccessAddGroup(ContentType contentType,
        string token,
        string groupId,
        string channelId,
        string? teamId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.conversations.restrictAccess.addGroup"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token),
                    new Param("group_id", groupId),
                    new Param("channel_id", channelId),
                    new Param("team_id", teamId)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_conversations_restrictAccess_listGroups
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.conversations:read</c></param>
    /// <param name="channelId"></param>
    /// <param name="teamId">The workspace where the channel exists. This argument is required for channels only tied to one workspace, and optional for channels that are shared across an organization.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all IDP Groups linked to a channel
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminConversationsRestrictAccessListGroups(string token,
        string channelId,
        string? teamId,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.conversations.restrictAccess.listGroups"),
            [],
            [new Param("token", token), new Param("channel_id", channelId), new Param("team_id", teamId)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_conversations_restrictAccess_removeGroup
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="teamId"></param>
    /// <param name="groupId"></param>
    /// <param name="channelId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Remove a linked IDP group linked from a private channel
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminConversationsRestrictAccessRemoveGroup(ContentType contentType,
        string token,
        string teamId,
        string groupId,
        string channelId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.conversations.restrictAccess.removeGroup"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token),
                    new Param("team_id", teamId),
                    new Param("group_id", groupId),
                    new Param("channel_id", channelId)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
