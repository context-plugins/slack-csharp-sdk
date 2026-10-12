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
using SlackWebApi.Requests.AdminApps;
using SlackWebApi.Requests.AdminAppsApproved;
using SlackWebApi.Requests.AdminAppsRequests;
using SlackWebApi.Requests.AdminAppsRestricted;
using SlackWebApi.Requests.AdminConversations;
using SlackWebApi.Requests.AdminConversationsEkm;
using SlackWebApi.Requests.AdminConversationsRestrictAccess;
using SlackWebApi.Requests.AdminEmoji;
using SlackWebApi.Requests.AdminInviteRequests;
using SlackWebApi.Requests.AdminInviteRequestsApproved;
using SlackWebApi.Requests.AdminInviteRequestsDenied;
using SlackWebApi.Requests.AdminTeams;
using SlackWebApi.Requests.AdminTeamsAdmins;
using SlackWebApi.Requests.AdminTeamsOwners;
using SlackWebApi.Requests.AdminTeamsSettings;
using SlackWebApi.Requests.AdminUsergroups;
using SlackWebApi.Requests.AdminUsers;
using SlackWebApi.Requests.AdminUsersSession;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Approve an app for installation on a workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminAppsApprove(AdminAppsApproveRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.apps.approve"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("app_id", request.AppId),
                new Param("request_id", request.RequestId),
                new Param("team_id", request.TeamId)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_apps_approved_list
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List approved apps for an org or workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminAppsApprovedList(AdminAppsApprovedListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.apps.approved.list"),
            [],
            [
                new Param("token", request.Token),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
                new Param("team_id", request.TeamId),
                new Param("enterprise_id", request.EnterpriseId),
            ],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_apps_requests_list
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List app requests for a team/workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminAppsRequestsList(AdminAppsRequestsListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.apps.requests.list"),
            [],
            [
                new Param("token", request.Token),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
                new Param("team_id", request.TeamId),
            ],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_apps_restrict
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Restrict an app for installation on a workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminAppsRestrict(AdminAppsRestrictRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.apps.restrict"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("app_id", request.AppId),
                new Param("request_id", request.RequestId),
                new Param("team_id", request.TeamId)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_apps_restricted_list
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List restricted apps for an org or workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminAppsRestrictedList(AdminAppsRestrictedListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.apps.restricted.list"),
            [],
            [
                new Param("token", request.Token),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
                new Param("team_id", request.TeamId),
                new Param("enterprise_id", request.EnterpriseId),
            ],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_conversations_archive
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsArchiveschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Archive a public or private channel.
    /// </remarks>
    public Task<AdminConversationsArchiveschema> AdminConversationsArchive(AdminConversationsArchiveRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.conversations.archive"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("channel_id", request.ChannelId)),
            JsonResponse.Create<AdminConversationsArchiveschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_conversations_convertToPrivate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsConvertToPrivateschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Convert a public channel to a private channel.
    /// </remarks>
    public Task<AdminConversationsConvertToPrivateschema> AdminConversationsConvertToPrivate(AdminConversationsConvertToPrivateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.conversations.convertToPrivate"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("channel_id", request.ChannelId)),
            JsonResponse.Create<AdminConversationsConvertToPrivateschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_conversations_create
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsCreateschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a public or private channel-based conversation.
    /// </remarks>
    public Task<AdminConversationsCreateschema> AdminConversationsCreate(AdminConversationsCreateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.conversations.create"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("name", request.Name),
                new Param("is_private", request.IsPrivate),
                new Param("description", request.Description),
                new Param("org_wide", request.OrgWide),
                new Param("team_id", request.TeamId)),
            JsonResponse.Create<AdminConversationsCreateschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_conversations_delete
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsDeleteschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a public or private channel.
    /// </remarks>
    public Task<AdminConversationsDeleteschema> AdminConversationsDelete(AdminConversationsDeleteRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.conversations.delete"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("channel_id", request.ChannelId)),
            JsonResponse.Create<AdminConversationsDeleteschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_conversations_disconnectShared
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsRenameschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Disconnect a connected channel from one or more workspaces.
    /// </remarks>
    public Task<AdminConversationsRenameschema> AdminConversationsDisconnectShared(AdminConversationsDisconnectSharedRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.conversations.disconnectShared"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("channel_id", request.ChannelId),
                new Param("leaving_team_ids", request.LeavingTeamIds)),
            JsonResponse.Create<AdminConversationsRenameschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_conversations_ekm_listOriginalConnectedChannelInfo
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all disconnected channels—i.e., channels that were once connected to other workspaces and then disconnected—and the corresponding original channel IDs for key revocation with EKM.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminConversationsEkmListOriginalConnectedChannelInfo(AdminConversationsEkmListOriginalConnectedChannelInfoRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.conversations.ekm.listOriginalConnectedChannelInfo"),
            [],
            [
                new Param("token", request.Token),
                new Param("channel_ids", request.ChannelIds),
                new Param("team_ids", request.TeamIds),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
            ],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_conversations_getConversationPrefs
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsGetConversationPrefsschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get conversation preferences for a public or private channel.
    /// </remarks>
    public Task<AdminConversationsGetConversationPrefsschema> AdminConversationsGetConversationPrefs(AdminConversationsGetConversationPrefsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.conversations.getConversationPrefs"),
            [],
            [new Param("channel_id", request.ChannelId)],
            [new HeaderParam("token", request.Token), new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AdminConversationsGetConversationPrefsschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_conversations_getTeams
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsGetTeamsschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get all the workspaces a given public or private channel is connected to within this Enterprise org.
    /// </remarks>
    public Task<AdminConversationsGetTeamsschema> AdminConversationsGetTeams(AdminConversationsGetTeamsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.conversations.getTeams"),
            [],
            [
                new Param("channel_id", request.ChannelId),
                new Param("cursor", request.Cursor),
                new Param("limit", request.Limit),
            ],
            [new HeaderParam("token", request.Token), new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AdminConversationsGetTeamsschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_conversations_invite
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsInviteschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Invite a user to a public or private channel.
    /// </remarks>
    public Task<AdminConversationsInviteschema> AdminConversationsInvite(AdminConversationsInviteRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.conversations.invite"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("user_ids", request.UserIds),
                new Param("channel_id", request.ChannelId)),
            JsonResponse.Create<AdminConversationsInviteschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_conversations_rename
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsRenameschema1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Rename a public or private channel.
    /// </remarks>
    public Task<AdminConversationsRenameschema1> AdminConversationsRename(AdminConversationsRenameRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.conversations.rename"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("channel_id", request.ChannelId), new Param("name", request.Name)),
            JsonResponse.Create<AdminConversationsRenameschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_conversations_restrictAccess_addGroup
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Add an allowlist of IDP groups for accessing a channel
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminConversationsRestrictAccessAddGroup(AdminConversationsRestrictAccessAddGroupRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.conversations.restrictAccess.addGroup"),
            [],
            [],
            [new HeaderParam("Content-Type", request.ContentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("token", request.Token),
                new Param("group_id", request.GroupId),
                new Param("channel_id", request.ChannelId),
                new Param("team_id", request.TeamId)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_conversations_restrictAccess_listGroups
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all IDP Groups linked to a channel
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminConversationsRestrictAccessListGroups(AdminConversationsRestrictAccessListGroupsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.conversations.restrictAccess.listGroups"),
            [],
            [
                new Param("token", request.Token),
                new Param("channel_id", request.ChannelId),
                new Param("team_id", request.TeamId),
            ],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_conversations_restrictAccess_removeGroup
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Remove a linked IDP group linked from a private channel
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminConversationsRestrictAccessRemoveGroup(AdminConversationsRestrictAccessRemoveGroupRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.conversations.restrictAccess.removeGroup"),
            [],
            [],
            [new HeaderParam("Content-Type", request.ContentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("token", request.Token),
                new Param("team_id", request.TeamId),
                new Param("group_id", request.GroupId),
                new Param("channel_id", request.ChannelId)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_conversations_search
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsSearchschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Search for public or private channels in an Enterprise organization.
    /// </remarks>
    public Task<AdminConversationsSearchschema> AdminConversationsSearch(AdminConversationsSearchRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.conversations.search"),
            [],
            [
                new Param("team_ids", request.TeamIds),
                new Param("query", request.Query),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
                new Param("search_channel_types", request.SearchChannelTypes),
                new Param("sort", request.Sort),
                new Param("sort_dir", request.SortDir),
            ],
            [new HeaderParam("token", request.Token), new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AdminConversationsSearchschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_conversations_setConversationPrefs
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsSetConversationPrefsschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set the posting permissions for a public or private channel.
    /// </remarks>
    public Task<AdminConversationsSetConversationPrefsschema> AdminConversationsSetConversationPrefs(AdminConversationsSetConversationPrefsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.conversations.setConversationPrefs"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("channel_id", request.ChannelId), new Param("prefs", request.Prefs)),
            JsonResponse.Create<AdminConversationsSetConversationPrefsschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_conversations_setTeams
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set the workspaces in an Enterprise grid org that connect to a public or private channel.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminConversationsSetTeams(AdminConversationsSetTeamsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.conversations.setTeams"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("channel_id", request.ChannelId),
                new Param("team_id", request.TeamId),
                new Param("target_team_ids", request.TargetTeamIds),
                new Param("org_channel", request.OrgChannel)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_conversations_unarchive
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminConversationsUnarchiveschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Unarchive a public or private channel.
    /// </remarks>
    public Task<AdminConversationsUnarchiveschema> AdminConversationsUnarchive(AdminConversationsUnarchiveRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.conversations.unarchive"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("channel_id", request.ChannelId)),
            JsonResponse.Create<AdminConversationsUnarchiveschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_emoji_add
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Add an emoji.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminEmojiAdd(AdminEmojiAddRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.emoji.add"),
            [],
            [],
            [new HeaderParam("Content-Type", request.ContentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("token", request.Token),
                new Param("name", request.Name),
                new Param("url", request.Url)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_emoji_addAlias
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Add an emoji alias.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminEmojiAddAlias(AdminEmojiAddAliasRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.emoji.addAlias"),
            [],
            [],
            [new HeaderParam("Content-Type", request.ContentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("token", request.Token),
                new Param("name", request.Name),
                new Param("alias_for", request.AliasFor)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_emoji_list
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List emoji for an Enterprise Grid organization.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminEmojiList(AdminEmojiListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.emoji.list"),
            [],
            [new Param("token", request.Token), new Param("cursor", request.Cursor), new Param("limit", request.Limit)],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_emoji_remove
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Remove an emoji across an Enterprise Grid organization
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminEmojiRemove(AdminEmojiRemoveRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.emoji.remove"),
            [],
            [],
            [new HeaderParam("Content-Type", request.ContentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("token", request.Token), new Param("name", request.Name)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_emoji_rename
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Rename an emoji.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminEmojiRename(AdminEmojiRenameRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.emoji.rename"),
            [],
            [],
            [new HeaderParam("Content-Type", request.ContentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("token", request.Token),
                new Param("name", request.Name),
                new Param("new_name", request.NewName)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_inviteRequests_approve
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Approve a workspace invite request.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminInviteRequestsApprove(AdminInviteRequestsApproveRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.inviteRequests.approve"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("invite_request_id", request.InviteRequestId),
                new Param("team_id", request.TeamId)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_inviteRequests_approved_list
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all approved workspace invite requests.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminInviteRequestsApprovedList(AdminInviteRequestsApprovedListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.inviteRequests.approved.list"),
            [],
            [
                new Param("team_id", request.TeamId),
                new Param("cursor", request.Cursor),
                new Param("limit", request.Limit),
            ],
            [new HeaderParam("token", request.Token), new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_inviteRequests_denied_list
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all denied workspace invite requests.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminInviteRequestsDeniedList(AdminInviteRequestsDeniedListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.inviteRequests.denied.list"),
            [],
            [
                new Param("team_id", request.TeamId),
                new Param("cursor", request.Cursor),
                new Param("limit", request.Limit),
            ],
            [new HeaderParam("token", request.Token), new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_inviteRequests_deny
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deny a workspace invite request.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminInviteRequestsDeny(AdminInviteRequestsDenyRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.inviteRequests.deny"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("invite_request_id", request.InviteRequestId),
                new Param("team_id", request.TeamId)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_inviteRequests_list
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all pending workspace invite requests.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminInviteRequestsList(AdminInviteRequestsListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.inviteRequests.list"),
            [],
            [
                new Param("team_id", request.TeamId),
                new Param("cursor", request.Cursor),
                new Param("limit", request.Limit),
            ],
            [new HeaderParam("token", request.Token), new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_teams_admins_list
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all of the admins on a given workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsAdminsList(AdminTeamsAdminsListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.teams.admins.list"),
            [],
            [
                new Param("token", request.Token),
                new Param("team_id", request.TeamId),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
            ],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_teams_create
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an Enterprise team.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsCreate(AdminTeamsCreateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.teams.create"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("team_domain", request.TeamDomain),
                new Param("team_name", request.TeamName),
                new Param("team_description", request.TeamDescription),
                new Param("team_discoverability", request.TeamDiscoverability)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_teams_list
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all teams on an Enterprise organization
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsList(AdminTeamsListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.teams.list"),
            [],
            [new Param("limit", request.Limit), new Param("cursor", request.Cursor)],
            [new HeaderParam("token", request.Token), new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_teams_owners_list
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all of the owners on a given workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsOwnersList(AdminTeamsOwnersListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.teams.owners.list"),
            [],
            [
                new Param("token", request.Token),
                new Param("team_id", request.TeamId),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
            ],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_teams_settings_info
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch information about settings in a workspace
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsSettingsInfo(AdminTeamsSettingsInfoRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.teams.settings.info"),
            [],
            [new Param("team_id", request.TeamId)],
            [new HeaderParam("token", request.Token), new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_teams_settings_setDefaultChannels
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set the default channels of a workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsSettingsSetDefaultChannels(AdminTeamsSettingsSetDefaultChannelsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.teams.settings.setDefaultChannels"),
            [],
            [],
            [new HeaderParam("Content-Type", request.ContentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("token", request.Token),
                new Param("team_id", request.TeamId),
                new Param("channel_ids", request.ChannelIds)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_teams_settings_setDescription
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set the description of a given workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsSettingsSetDescription(AdminTeamsSettingsSetDescriptionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.teams.settings.setDescription"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("team_id", request.TeamId),
                new Param("description", request.Description)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_teams_settings_setDiscoverability
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// An API method that allows admins to set the discoverability of a given workspace
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsSettingsSetDiscoverability(AdminTeamsSettingsSetDiscoverabilityRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.teams.settings.setDiscoverability"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("team_id", request.TeamId),
                new Param("discoverability", request.Discoverability)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_teams_settings_setIcon
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sets the icon of a workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsSettingsSetIcon(AdminTeamsSettingsSetIconRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.teams.settings.setIcon"),
            [],
            [],
            [new HeaderParam("Content-Type", request.ContentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("token", request.Token),
                new Param("image_url", request.ImageUrl),
                new Param("team_id", request.TeamId)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_teams_settings_setName
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set the name of a given workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsSettingsSetName(AdminTeamsSettingsSetNameRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.teams.settings.setName"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("team_id", request.TeamId), new Param("name", request.Name)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_usergroups_addChannels
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Add one or more default channels to an IDP group.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsergroupsAddChannels(AdminUsergroupsAddChannelsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.usergroups.addChannels"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("usergroup_id", request.UsergroupId),
                new Param("channel_ids", request.ChannelIds),
                new Param("team_id", request.TeamId)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_usergroups_addTeams
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Associate one or more default workspaces with an organization-wide IDP group.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsergroupsAddTeams(AdminUsergroupsAddTeamsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.usergroups.addTeams"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("usergroup_id", request.UsergroupId),
                new Param("team_ids", request.TeamIds),
                new Param("auto_provision", request.AutoProvision)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_usergroups_listChannels
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List the channels linked to an org-level IDP group (user group).
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsergroupsListChannels(AdminUsergroupsListChannelsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.usergroups.listChannels"),
            [],
            [
                new Param("usergroup_id", request.UsergroupId),
                new Param("team_id", request.TeamId),
                new Param("include_num_members", request.IncludeNumMembers),
            ],
            [new HeaderParam("token", request.Token), new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_usergroups_removeChannels
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Remove one or more default channels from an org-level IDP group (user group).
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsergroupsRemoveChannels(AdminUsergroupsRemoveChannelsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.usergroups.removeChannels"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("usergroup_id", request.UsergroupId),
                new Param("channel_ids", request.ChannelIds)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_users_assign
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Add an Enterprise user to a workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersAssign(AdminUsersAssignRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.users.assign"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("team_id", request.TeamId),
                new Param("user_id", request.UserId),
                new Param("is_restricted", request.IsRestricted),
                new Param("is_ultra_restricted", request.IsUltraRestricted),
                new Param("channel_ids", request.ChannelIds)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_users_invite
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Invite a user to a workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersInvite(AdminUsersInviteRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.users.invite"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("team_id", request.TeamId),
                new Param("email", request.Email),
                new Param("channel_ids", request.ChannelIds),
                new Param("custom_message", request.CustomMessage),
                new Param("real_name", request.RealName),
                new Param("resend", request.Resend),
                new Param("is_restricted", request.IsRestricted),
                new Param("is_ultra_restricted", request.IsUltraRestricted),
                new Param("guest_expiration_ts", request.GuestExpirationTs)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_users_list
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List users on a workspace
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersList(AdminUsersListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.users.list"),
            [],
            [
                new Param("team_id", request.TeamId),
                new Param("cursor", request.Cursor),
                new Param("limit", request.Limit),
            ],
            [new HeaderParam("token", request.Token), new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_users_remove
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Remove a user from a workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersRemove(AdminUsersRemoveRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.users.remove"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("team_id", request.TeamId), new Param("user_id", request.UserId)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_users_session_invalidate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Invalidate a single session for a user by session_id
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersSessionInvalidate(AdminUsersSessionInvalidateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.users.session.invalidate"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("team_id", request.TeamId),
                new Param("session_id", request.SessionId)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_users_session_reset
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Wipes all valid sessions on all devices for a given user
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersSessionReset(AdminUsersSessionResetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.users.session.reset"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("user_id", request.UserId),
                new Param("mobile_only", request.MobileOnly),
                new Param("web_only", request.WebOnly)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_users_setAdmin
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set an existing guest, regular user, or owner to be an admin user.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersSetAdmin(AdminUsersSetAdminRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.users.setAdmin"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("team_id", request.TeamId), new Param("user_id", request.UserId)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_users_setExpiration
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set an expiration for a guest user
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersSetExpiration(AdminUsersSetExpirationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.users.setExpiration"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("team_id", request.TeamId),
                new Param("user_id", request.UserId),
                new Param("expiration_ts", request.ExpirationTs)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_users_setOwner
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set an existing guest, regular user, or admin user to be a workspace owner.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersSetOwner(AdminUsersSetOwnerRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.users.setOwner"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("team_id", request.TeamId), new Param("user_id", request.UserId)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// admin_users_setRegular
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set an existing guest user, admin user, or owner to be a regular user.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersSetRegular(AdminUsersSetRegularRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/admin.users.setRegular"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("team_id", request.TeamId), new Param("user_id", request.UserId)),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);
}
