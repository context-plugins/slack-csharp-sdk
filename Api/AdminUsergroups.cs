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

public sealed class AdminUsergroups
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AdminUsergroups(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

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
    /// admin_usergroups_addChannels
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.usergroups:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="usergroupId"></param>
    /// <param name="channelIds"></param>
    /// <param name="teamId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Add one or more default channels to an IDP group.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AdminUsergroupsAddChannels1(string token,
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
            JsonResponse.Create<Defaultsuccesstemplate1>(),
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
    /// admin_usergroups_addTeams
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.teams:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="usergroupId"></param>
    /// <param name="teamIds"></param>
    /// <param name="autoProvision"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Associate one or more default workspaces with an organization-wide IDP group.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AdminUsergroupsAddTeams1(string token,
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
            JsonResponse.Create<Defaultsuccesstemplate1>(),
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
    /// admin_usergroups_listChannels
    /// </summary>
    /// <param name="usergroupId">ID of the IDP group to list default channels for.</param>
    /// <param name="teamId">ID of the the workspace.</param>
    /// <param name="includeNumMembers">Flag to include or exclude the count of members per channel.</param>
    /// <param name="token">Authentication token. Requires scope: <c>admin.usergroups:read</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List the channels linked to an org-level IDP group (user group).
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AdminUsergroupsListChannels1(string usergroupId,
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
            JsonResponse.Create<Defaultsuccesstemplate1>(),
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
    /// admin_usergroups_removeChannels
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.usergroups:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="usergroupId"></param>
    /// <param name="channelIds"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Remove one or more default channels from an org-level IDP group (user group).
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AdminUsergroupsRemoveChannels1(string token,
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
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
