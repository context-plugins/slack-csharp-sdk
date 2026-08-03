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

public sealed class AdminConversations
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AdminConversations(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

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
}
