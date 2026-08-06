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
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Api;

public sealed class Admin
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Admin(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// admin_apps_approve
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.apps:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="appId"></param>
    /// <param name="requestId"></param>
    /// <param name="teamId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Approve an app for installation on a workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminAppsApprove(string token,
        ContentType contentType,
        string? appId,
        string? requestId,
        string? teamId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.apps.approve"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("app_id", appId),
                    new Param("request_id", requestId),
                    new Param("team_id", teamId)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_apps_approved_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.apps:read</c></param>
    /// <param name="limit">The maximum number of items to return. Must be between 1 - 1000 both inclusive.</param>
    /// <param name="cursor">Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page</param>
    /// <param name="teamId"></param>
    /// <param name="enterpriseId"></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List approved apps for an org or workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminAppsApprovedList(string token,
        int? limit,
        string? cursor,
        string? teamId,
        string? enterpriseId,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.apps.approved.list"),
            [],
            [new Param("token", token),
                new Param("limit", limit),
                new Param("cursor", cursor),
                new Param("team_id", teamId),
                new Param("enterprise_id", enterpriseId)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_apps_requests_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.apps:read</c></param>
    /// <param name="limit">The maximum number of items to return. Must be between 1 - 1000 both inclusive.</param>
    /// <param name="cursor">Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page</param>
    /// <param name="teamId"></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List app requests for a team/workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminAppsRequestsList(string token,
        int? limit,
        string? cursor,
        string? teamId,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.apps.requests.list"),
            [],
            [new Param("token", token),
                new Param("limit", limit),
                new Param("cursor", cursor),
                new Param("team_id", teamId)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_apps_restrict
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.apps:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="appId"></param>
    /// <param name="requestId"></param>
    /// <param name="teamId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Restrict an app for installation on a workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminAppsRestrict(string token,
        ContentType contentType,
        string? appId,
        string? requestId,
        string? teamId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.apps.restrict"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("app_id", appId),
                    new Param("request_id", requestId),
                    new Param("team_id", teamId)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_apps_restricted_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.apps:read</c></param>
    /// <param name="limit">The maximum number of items to return. Must be between 1 - 1000 both inclusive.</param>
    /// <param name="cursor">Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page</param>
    /// <param name="teamId"></param>
    /// <param name="enterpriseId"></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List restricted apps for an org or workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminAppsRestrictedList(string token,
        int? limit,
        string? cursor,
        string? teamId,
        string? enterpriseId,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.apps.restricted.list"),
            [],
            [new Param("token", token),
                new Param("limit", limit),
                new Param("cursor", cursor),
                new Param("team_id", teamId),
                new Param("enterprise_id", enterpriseId)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_conversations_archive
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.conversations:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="channelId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsArchiveschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Archive a public or private channel.
    /// </remarks>
    public Task<AdminConversationsArchiveschema> AdminConversationsArchive(string token,
        ContentType contentType,
        string channelId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.conversations.archive"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel_id", channelId)]),
            JsonResponse.Create<AdminConversationsArchiveschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_conversations_convertToPrivate
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.conversations:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="channelId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsConvertToPrivateschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Convert a public channel to a private channel.
    /// </remarks>
    public Task<AdminConversationsConvertToPrivateschema> AdminConversationsConvertToPrivate(string token,
        ContentType contentType,
        string channelId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.conversations.convertToPrivate"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel_id", channelId)]),
            JsonResponse.Create<AdminConversationsConvertToPrivateschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_conversations_create
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.conversations:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="name"></param>
    /// <param name="isPrivate"></param>
    /// <param name="description"></param>
    /// <param name="orgWide"></param>
    /// <param name="teamId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsCreateschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a public or private channel-based conversation.
    /// </remarks>
    public Task<AdminConversationsCreateschema> AdminConversationsCreate(string token,
        ContentType contentType,
        string name,
        bool isPrivate,
        string? description,
        bool? orgWide,
        string? teamId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.conversations.create"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("name", name),
                    new Param("is_private", isPrivate),
                    new Param("description", description),
                    new Param("org_wide", orgWide),
                    new Param("team_id", teamId)]),
            JsonResponse.Create<AdminConversationsCreateschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_conversations_delete
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.conversations:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="channelId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsDeleteschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a public or private channel.
    /// </remarks>
    public Task<AdminConversationsDeleteschema> AdminConversationsDelete(string token,
        ContentType contentType,
        string channelId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.conversations.delete"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel_id", channelId)]),
            JsonResponse.Create<AdminConversationsDeleteschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_conversations_disconnectShared
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.conversations:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="channelId"></param>
    /// <param name="leavingTeamIds"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsRenameschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Disconnect a connected channel from one or more workspaces.
    /// </remarks>
    public Task<AdminConversationsRenameschema> AdminConversationsDisconnectShared(string token,
        ContentType contentType,
        string channelId,
        string? leavingTeamIds,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.conversations.disconnectShared"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel_id", channelId),
                    new Param("leaving_team_ids", leavingTeamIds)]),
            JsonResponse.Create<AdminConversationsRenameschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_conversations_ekm_listOriginalConnectedChannelInfo
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.conversations:read</c></param>
    /// <param name="channelIds">A comma-separated list of channels to filter to.</param>
    /// <param name="teamIds">A comma-separated list of the workspaces to which the channels you would like returned belong.</param>
    /// <param name="limit">The maximum number of items to return. Must be between 1 - 1000 both inclusive.</param>
    /// <param name="cursor">Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all disconnected channels—i.e., channels that were once connected to other workspaces and then disconnected—and the corresponding original channel IDs for key revocation with EKM.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminConversationsEkmListOriginalConnectedChannelInfo(string token,
        string? channelIds,
        string? teamIds,
        int? limit,
        string? cursor,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.conversations.ekm.listOriginalConnectedChannelInfo"),
            [],
            [new Param("token", token),
                new Param("channel_ids", channelIds),
                new Param("team_ids", teamIds),
                new Param("limit", limit),
                new Param("cursor", cursor)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_conversations_getConversationPrefs
    /// </summary>
    /// <param name="channelId">The channel to get preferences for.</param>
    /// <param name="token">Authentication token. Requires scope: <c>admin.conversations:read</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsGetConversationPrefsschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get conversation preferences for a public or private channel.
    /// </remarks>
    public Task<AdminConversationsGetConversationPrefsschema> AdminConversationsGetConversationPrefs(string channelId,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.conversations.getConversationPrefs"),
            [],
            [new Param("channel_id", channelId)],
            [new HeaderParam("token", token), new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AdminConversationsGetConversationPrefsschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_conversations_getTeams
    /// </summary>
    /// <param name="channelId">The channel to determine connected workspaces within the organization for.</param>
    /// <param name="cursor">Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page</param>
    /// <param name="limit">The maximum number of items to return. Must be between 1 - 1000 both inclusive.</param>
    /// <param name="token">Authentication token. Requires scope: <c>admin.conversations:read</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsGetTeamsschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get all the workspaces a given public or private channel is connected to within this Enterprise org.
    /// </remarks>
    public Task<AdminConversationsGetTeamsschema> AdminConversationsGetTeams(string channelId,
        string? cursor,
        int? limit,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.conversations.getTeams"),
            [],
            [new Param("channel_id", channelId), new Param("cursor", cursor), new Param("limit", limit)],
            [new HeaderParam("token", token), new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AdminConversationsGetTeamsschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_conversations_invite
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.conversations:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="userIds"></param>
    /// <param name="channelId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsInviteschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Invite a user to a public or private channel.
    /// </remarks>
    public Task<AdminConversationsInviteschema> AdminConversationsInvite(string token,
        ContentType contentType,
        string userIds,
        string channelId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.conversations.invite"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("user_ids", userIds), new Param("channel_id", channelId)]),
            JsonResponse.Create<AdminConversationsInviteschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_conversations_rename
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.conversations:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="channelId"></param>
    /// <param name="name"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsRenameschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Rename a public or private channel.
    /// </remarks>
    public Task<AdminConversationsRenameschema1> AdminConversationsRename(string token,
        ContentType contentType,
        string channelId,
        string name,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.conversations.rename"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel_id", channelId), new Param("name", name)]),
            JsonResponse.Create<AdminConversationsRenameschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

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

    /// <summary>
    /// admin_conversations_search
    /// </summary>
    /// <param name="teamIds">Comma separated string of team IDs, signifying the workspaces to search through.</param>
    /// <param name="query">Name of the the channel to query by.</param>
    /// <param name="limit">Maximum number of items to be returned. Must be between 1 - 20 both inclusive. Default is 10.</param>
    /// <param name="cursor">Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page.</param>
    /// <param name="searchChannelTypes">The type of channel to include or exclude in the search. For example <c>private</c> will search private channels, while <c>private_exclude</c> will exclude them. For a full list of types, check the <see href="#types">Types section</see>.</param>
    /// <param name="sort">Possible values are <c>relevant</c> (search ranking based on what we think is closest), <c>name</c> (alphabetical), <c>member_count</c> (number of users in the channel), and <c>created</c> (date channel was created). You can optionally pair this with the <c>sort_dir</c> arg to change how it is sorted</param>
    /// <param name="sortDir">Sort direction. Possible values are <c>asc</c> for ascending order like (1, 2, 3) or (a, b, c), and <c>desc</c> for descending order like (3, 2, 1) or (c, b, a)</param>
    /// <param name="token">Authentication token. Requires scope: <c>admin.conversations:read</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsSearchschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Search for public or private channels in an Enterprise organization.
    /// </remarks>
    public Task<AdminConversationsSearchschema> AdminConversationsSearch(string? teamIds,
        string? query,
        int? limit,
        string? cursor,
        string? searchChannelTypes,
        string? sort,
        string? sortDir,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.conversations.search"),
            [],
            [new Param("team_ids", teamIds),
                new Param("query", query),
                new Param("limit", limit),
                new Param("cursor", cursor),
                new Param("search_channel_types", searchChannelTypes),
                new Param("sort", sort),
                new Param("sort_dir", sortDir)],
            [new HeaderParam("token", token), new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AdminConversationsSearchschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_conversations_setConversationPrefs
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.conversations:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="channelId"></param>
    /// <param name="prefs"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsSetConversationPrefsschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set the posting permissions for a public or private channel.
    /// </remarks>
    public Task<AdminConversationsSetConversationPrefsschema> AdminConversationsSetConversationPrefs(string token,
        ContentType contentType,
        string channelId,
        string prefs,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.conversations.setConversationPrefs"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel_id", channelId), new Param("prefs", prefs)]),
            JsonResponse.Create<AdminConversationsSetConversationPrefsschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_conversations_setTeams
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.conversations:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="channelId"></param>
    /// <param name="teamId"></param>
    /// <param name="targetTeamIds"></param>
    /// <param name="orgChannel"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set the workspaces in an Enterprise grid org that connect to a public or private channel.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminConversationsSetTeams(string token,
        ContentType contentType,
        string channelId,
        string? teamId,
        string? targetTeamIds,
        bool? orgChannel,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.conversations.setTeams"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel_id", channelId),
                    new Param("team_id", teamId),
                    new Param("target_team_ids", targetTeamIds),
                    new Param("org_channel", orgChannel)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_conversations_unarchive
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.conversations:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="channelId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsUnarchiveschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Unarchive a public or private channel.
    /// </remarks>
    public Task<AdminConversationsUnarchiveschema> AdminConversationsUnarchive(string token,
        ContentType contentType,
        string channelId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.conversations.unarchive"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel_id", channelId)]),
            JsonResponse.Create<AdminConversationsUnarchiveschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_emoji_add
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="name"></param>
    /// <param name="url"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Add an emoji.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminEmojiAdd(ContentType contentType,
        string token,
        string name,
        string url,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.emoji.add"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token),
                    new Param("name", name),
                    new Param("url", url)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_emoji_addAlias
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="name"></param>
    /// <param name="aliasFor"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Add an emoji alias.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminEmojiAddAlias(ContentType contentType,
        string token,
        string name,
        string aliasFor,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.emoji.addAlias"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token),
                    new Param("name", name),
                    new Param("alias_for", aliasFor)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_emoji_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.teams:read</c></param>
    /// <param name="cursor">Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page</param>
    /// <param name="limit">The maximum number of items to return. Must be between 1 - 1000 both inclusive.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List emoji for an Enterprise Grid organization.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminEmojiList(string token,
        string? cursor,
        int? limit,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.emoji.list"),
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
    /// admin_emoji_remove
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="name"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Remove an emoji across an Enterprise Grid organization
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminEmojiRemove(ContentType contentType,
        string token,
        string name,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.emoji.remove"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token), new Param("name", name)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_emoji_rename
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="name"></param>
    /// <param name="newName"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Rename an emoji.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminEmojiRename(ContentType contentType,
        string token,
        string name,
        string newName,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.emoji.rename"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token),
                    new Param("name", name),
                    new Param("new_name", newName)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

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
    /// admin_inviteRequests_approved_list
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
    /// List all approved workspace invite requests.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminInviteRequestsApprovedList(string? teamId,
        string? cursor,
        int? limit,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.inviteRequests.approved.list"),
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

    /// <summary>
    /// admin_inviteRequests_denied_list
    /// </summary>
    /// <param name="teamId">ID for the workspace where the invite requests were made.</param>
    /// <param name="cursor">Value of the <c>next_cursor</c> field sent as part of the previous api response</param>
    /// <param name="limit">The number of results that will be returned by the API on each invocation. Must be between 1 - 1000 both inclusive</param>
    /// <param name="token">Authentication token. Requires scope: <c>admin.invites:read</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all denied workspace invite requests.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminInviteRequestsDeniedList(string? teamId,
        string? cursor,
        int? limit,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.inviteRequests.denied.list"),
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

    /// <summary>
    /// admin_teams_admins_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.teams:read</c></param>
    /// <param name="teamId"></param>
    /// <param name="limit">The maximum number of items to return.</param>
    /// <param name="cursor">Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all of the admins on a given workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsAdminsList(string token,
        string teamId,
        int? limit,
        string? cursor,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.teams.admins.list"),
            [],
            [new Param("token", token),
                new Param("team_id", teamId),
                new Param("limit", limit),
                new Param("cursor", cursor)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_teams_create
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.teams:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamDomain"></param>
    /// <param name="teamName"></param>
    /// <param name="teamDescription"></param>
    /// <param name="teamDiscoverability"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an Enterprise team.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsCreate(string token,
        ContentType contentType,
        string teamDomain,
        string teamName,
        string? teamDescription,
        string? teamDiscoverability,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.teams.create"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_domain", teamDomain),
                    new Param("team_name", teamName),
                    new Param("team_description", teamDescription),
                    new Param("team_discoverability", teamDiscoverability)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_teams_list
    /// </summary>
    /// <param name="limit">The maximum number of items to return. Must be between 1 - 100 both inclusive.</param>
    /// <param name="cursor">Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page.</param>
    /// <param name="token">Authentication token. Requires scope: <c>admin.teams:read</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all teams on an Enterprise organization
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsList(int? limit,
        string? cursor,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.teams.list"),
            [],
            [new Param("limit", limit), new Param("cursor", cursor)],
            [new HeaderParam("token", token), new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_teams_owners_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.teams:read</c></param>
    /// <param name="teamId"></param>
    /// <param name="limit">The maximum number of items to return. Must be between 1 - 1000 both inclusive.</param>
    /// <param name="cursor">Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all of the owners on a given workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsOwnersList(string token,
        string teamId,
        int? limit,
        string? cursor,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.teams.owners.list"),
            [],
            [new Param("token", token),
                new Param("team_id", teamId),
                new Param("limit", limit),
                new Param("cursor", cursor)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_teams_settings_info
    /// </summary>
    /// <param name="teamId"></param>
    /// <param name="token">Authentication token. Requires scope: <c>admin.teams:read</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch information about settings in a workspace
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsSettingsInfo(string teamId,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.teams.settings.info"),
            [],
            [new Param("team_id", teamId)],
            [new HeaderParam("token", token), new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_teams_settings_setDefaultChannels
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="teamId"></param>
    /// <param name="channelIds"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set the default channels of a workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsSettingsSetDefaultChannels(ContentType contentType,
        string token,
        string teamId,
        string channelIds,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.teams.settings.setDefaultChannels"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token),
                    new Param("team_id", teamId),
                    new Param("channel_ids", channelIds)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_teams_settings_setDescription
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.teams:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="description"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set the description of a given workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsSettingsSetDescription(string token,
        ContentType contentType,
        string teamId,
        string description,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.teams.settings.setDescription"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId), new Param("description", description)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_teams_settings_setDiscoverability
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.teams:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="discoverability"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// An API method that allows admins to set the discoverability of a given workspace
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsSettingsSetDiscoverability(string token,
        ContentType contentType,
        string teamId,
        string discoverability,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.teams.settings.setDiscoverability"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId),
                    new Param("discoverability", discoverability)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_teams_settings_setIcon
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="imageUrl"></param>
    /// <param name="teamId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sets the icon of a workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsSettingsSetIcon(ContentType contentType,
        string token,
        string imageUrl,
        string teamId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.teams.settings.setIcon"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token),
                    new Param("image_url", imageUrl),
                    new Param("team_id", teamId)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_teams_settings_setName
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.teams:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="name"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set the name of a given workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsSettingsSetName(string token,
        ContentType contentType,
        string teamId,
        string name,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.teams.settings.setName"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId), new Param("name", name)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_usergroups_addChannels
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.usergroups:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="usergroupId"></param>
    /// <param name="channelIds"></param>
    /// <param name="teamId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Add one or more default channels to an IDP group.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsergroupsAddChannels(string token,
        ContentType contentType,
        string usergroupId,
        string channelIds,
        string? teamId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.usergroups.addChannels"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("usergroup_id", usergroupId),
                    new Param("channel_ids", channelIds),
                    new Param("team_id", teamId)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_usergroups_addTeams
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.teams:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="usergroupId"></param>
    /// <param name="teamIds"></param>
    /// <param name="autoProvision"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Associate one or more default workspaces with an organization-wide IDP group.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsergroupsAddTeams(string token,
        ContentType contentType,
        string usergroupId,
        string teamIds,
        bool? autoProvision,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.usergroups.addTeams"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("usergroup_id", usergroupId),
                    new Param("team_ids", teamIds),
                    new Param("auto_provision", autoProvision)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_usergroups_listChannels
    /// </summary>
    /// <param name="usergroupId">ID of the IDP group to list default channels for.</param>
    /// <param name="teamId">ID of the the workspace.</param>
    /// <param name="includeNumMembers">Flag to include or exclude the count of members per channel.</param>
    /// <param name="token">Authentication token. Requires scope: <c>admin.usergroups:read</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List the channels linked to an org-level IDP group (user group).
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsergroupsListChannels(string usergroupId,
        string? teamId,
        bool? includeNumMembers,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.usergroups.listChannels"),
            [],
            [new Param("usergroup_id", usergroupId),
                new Param("team_id", teamId),
                new Param("include_num_members", includeNumMembers)],
            [new HeaderParam("token", token), new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_usergroups_removeChannels
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.usergroups:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="usergroupId"></param>
    /// <param name="channelIds"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Remove one or more default channels from an org-level IDP group (user group).
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsergroupsRemoveChannels(string token,
        ContentType contentType,
        string usergroupId,
        string channelIds,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.usergroups.removeChannels"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("usergroup_id", usergroupId),
                    new Param("channel_ids", channelIds)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_assign
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="userId"></param>
    /// <param name="isRestricted"></param>
    /// <param name="isUltraRestricted"></param>
    /// <param name="channelIds"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Add an Enterprise user to a workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersAssign(string token,
        ContentType contentType,
        string teamId,
        string userId,
        bool? isRestricted,
        bool? isUltraRestricted,
        string? channelIds,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.assign"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId),
                    new Param("user_id", userId),
                    new Param("is_restricted", isRestricted),
                    new Param("is_ultra_restricted", isUltraRestricted),
                    new Param("channel_ids", channelIds)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_invite
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="email"></param>
    /// <param name="channelIds"></param>
    /// <param name="customMessage"></param>
    /// <param name="realName"></param>
    /// <param name="resend"></param>
    /// <param name="isRestricted"></param>
    /// <param name="isUltraRestricted"></param>
    /// <param name="guestExpirationTs"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Invite a user to a workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersInvite(string token,
        ContentType contentType,
        string teamId,
        string email,
        string channelIds,
        string? customMessage,
        string? realName,
        bool? resend,
        bool? isRestricted,
        bool? isUltraRestricted,
        string? guestExpirationTs,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.invite"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId),
                    new Param("email", email),
                    new Param("channel_ids", channelIds),
                    new Param("custom_message", customMessage),
                    new Param("real_name", realName),
                    new Param("resend", resend),
                    new Param("is_restricted", isRestricted),
                    new Param("is_ultra_restricted", isUltraRestricted),
                    new Param("guest_expiration_ts", guestExpirationTs)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_list
    /// </summary>
    /// <param name="teamId">The ID (<c>T1234</c>) of the workspace.</param>
    /// <param name="cursor">Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page.</param>
    /// <param name="limit">Limit for how many users to be retrieved per page</param>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:read</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List users on a workspace
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersList(string teamId,
        string? cursor,
        int? limit,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.list"),
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

    /// <summary>
    /// admin_users_remove
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="userId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Remove a user from a workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersRemove(string token,
        ContentType contentType,
        string teamId,
        string userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.remove"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId), new Param("user_id", userId)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_session_invalidate
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="sessionId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Invalidate a single session for a user by session_id
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersSessionInvalidate(string token,
        ContentType contentType,
        string teamId,
        int sessionId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.session.invalidate"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId), new Param("session_id", sessionId)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_session_reset
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="userId"></param>
    /// <param name="mobileOnly"></param>
    /// <param name="webOnly"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Wipes all valid sessions on all devices for a given user
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersSessionReset(string token,
        ContentType contentType,
        string userId,
        bool? mobileOnly,
        bool? webOnly,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.session.reset"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("user_id", userId),
                    new Param("mobile_only", mobileOnly),
                    new Param("web_only", webOnly)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_setAdmin
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="userId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set an existing guest, regular user, or owner to be an admin user.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersSetAdmin(string token,
        ContentType contentType,
        string teamId,
        string userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.setAdmin"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId), new Param("user_id", userId)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_setExpiration
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="userId"></param>
    /// <param name="expirationTs"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set an expiration for a guest user
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersSetExpiration(string token,
        ContentType contentType,
        string teamId,
        string userId,
        int expirationTs,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.setExpiration"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId),
                    new Param("user_id", userId),
                    new Param("expiration_ts", expirationTs)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_setOwner
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="userId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set an existing guest, regular user, or admin user to be a workspace owner.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersSetOwner(string token,
        ContentType contentType,
        string teamId,
        string userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.setOwner"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId), new Param("user_id", userId)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_setRegular
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="userId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set an existing guest user, admin user, or owner to be a regular user.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersSetRegular(string token,
        ContentType contentType,
        string teamId,
        string userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.setRegular"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId), new Param("user_id", userId)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
