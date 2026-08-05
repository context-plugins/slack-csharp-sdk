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

public sealed class Conversations
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Conversations(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// conversations_archive
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="channel"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsArchivesuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Archives a conversation.
    /// </remarks>
    public Task<ConversationsArchivesuccessschema> ConversationsArchive(ContentType contentType,
        string? token,
        string? channel,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.archive"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel)]),
            JsonResponse.Create<ConversationsArchivesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_archive
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="channel"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsArchivesuccessschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Archives a conversation.
    /// </remarks>
    public Task<ConversationsArchivesuccessschema1> ConversationsArchive1(ContentType contentType,
        string? token,
        string? channel,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.archive"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel)]),
            JsonResponse.Create<ConversationsArchivesuccessschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_close
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="channel"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsClosesuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Closes a direct message or multi-person direct message.
    /// </remarks>
    public Task<ConversationsClosesuccessschema> ConversationsClose(ContentType contentType,
        string? token,
        string? channel,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.close"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel)]),
            JsonResponse.Create<ConversationsClosesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_close
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="channel"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsClosesuccessschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Closes a direct message or multi-person direct message.
    /// </remarks>
    public Task<ConversationsClosesuccessschema1> ConversationsClose1(ContentType contentType,
        string? token,
        string? channel,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.close"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel)]),
            JsonResponse.Create<ConversationsClosesuccessschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_create
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="name"></param>
    /// <param name="isPrivate"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsCreatesuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Initiates a public or private channel-based conversation
    /// </remarks>
    public Task<ConversationsCreatesuccessschema> ConversationsCreate(ContentType contentType,
        string? token,
        string? name,
        bool? isPrivate,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.create"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("name", name), new Param("is_private", isPrivate)]),
            JsonResponse.Create<ConversationsCreatesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_create
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="name"></param>
    /// <param name="isPrivate"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsCreatesuccessschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Initiates a public or private channel-based conversation
    /// </remarks>
    public Task<ConversationsCreatesuccessschema1> ConversationsCreate1(ContentType contentType,
        string? token,
        string? name,
        bool? isPrivate,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.create"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("name", name), new Param("is_private", isPrivate)]),
            JsonResponse.Create<ConversationsCreatesuccessschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_history
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:history</c></param>
    /// <param name="channel">Conversation ID to fetch history for.</param>
    /// <param name="latest">End of time range of messages to include in results.</param>
    /// <param name="oldest">Start of time range of messages to include in results.</param>
    /// <param name="inclusive">Include messages with latest or oldest timestamp in results only when either timestamp is specified.</param>
    /// <param name="limit">The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the users list hasn't been reached.</param>
    /// <param name="cursor">Paginate through collections of data by setting the <c>cursor</c> parameter to a <c>next_cursor</c> attribute returned by a previous request's <c>response_metadata</c>. Default value fetches the first "page" of the collection.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsHistorysuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetches a conversation's history of messages and events.
    /// </remarks>
    public Task<ConversationsHistorysuccessschema> ConversationsHistory(string? token,
        string? channel,
        double? latest,
        double? oldest,
        bool? inclusive,
        int? limit,
        string? cursor,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.history"),
            [],
            [new Param("token", token),
                new Param("channel", channel),
                new Param("latest", latest),
                new Param("oldest", oldest),
                new Param("inclusive", inclusive),
                new Param("limit", limit),
                new Param("cursor", cursor)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ConversationsHistorysuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_history
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:history</c></param>
    /// <param name="channel">Conversation ID to fetch history for.</param>
    /// <param name="latest">End of time range of messages to include in results.</param>
    /// <param name="oldest">Start of time range of messages to include in results.</param>
    /// <param name="inclusive">Include messages with latest or oldest timestamp in results only when either timestamp is specified.</param>
    /// <param name="limit">The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the users list hasn't been reached.</param>
    /// <param name="cursor">Paginate through collections of data by setting the <c>cursor</c> parameter to a <c>next_cursor</c> attribute returned by a previous request's <c>response_metadata</c>. Default value fetches the first "page" of the collection.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsHistorysuccessschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetches a conversation's history of messages and events.
    /// </remarks>
    public Task<ConversationsHistorysuccessschema1> ConversationsHistory1(string? token,
        string? channel,
        double? latest,
        double? oldest,
        bool? inclusive,
        int? limit,
        string? cursor,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.history"),
            [],
            [new Param("token", token),
                new Param("channel", channel),
                new Param("latest", latest),
                new Param("oldest", oldest),
                new Param("inclusive", inclusive),
                new Param("limit", limit),
                new Param("cursor", cursor)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ConversationsHistorysuccessschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_info
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:read</c></param>
    /// <param name="channel">Conversation ID to learn more about</param>
    /// <param name="includeLocale">Set this to <c>true</c> to receive the locale for this conversation. Defaults to <c>false</c></param>
    /// <param name="includeNumMembers">Set to <c>true</c> to include the member count for the specified conversation. Defaults to <c>false</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsInfosuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve information about a conversation.
    /// </remarks>
    public Task<ConversationsInfosuccessschema> ConversationsInfo(string? token,
        string? channel,
        bool? includeLocale,
        bool? includeNumMembers,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.info"),
            [],
            [new Param("token", token),
                new Param("channel", channel),
                new Param("include_locale", includeLocale),
                new Param("include_num_members", includeNumMembers)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ConversationsInfosuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_info
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:read</c></param>
    /// <param name="channel">Conversation ID to learn more about</param>
    /// <param name="includeLocale">Set this to <c>true</c> to receive the locale for this conversation. Defaults to <c>false</c></param>
    /// <param name="includeNumMembers">Set to <c>true</c> to include the member count for the specified conversation. Defaults to <c>false</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsInfosuccessschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve information about a conversation.
    /// </remarks>
    public Task<ConversationsInfosuccessschema1> ConversationsInfo1(string? token,
        string? channel,
        bool? includeLocale,
        bool? includeNumMembers,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.info"),
            [],
            [new Param("token", token),
                new Param("channel", channel),
                new Param("include_locale", includeLocale),
                new Param("include_num_members", includeNumMembers)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ConversationsInfosuccessschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_invite
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="channel"></param>
    /// <param name="users"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsInviteerrorschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Invites users to a channel.
    /// </remarks>
    public Task<ConversationsInviteerrorschema> ConversationsInvite(ContentType contentType,
        string? token,
        string? channel,
        string? users,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.invite"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel), new Param("users", users)]),
            JsonResponse.Create<ConversationsInviteerrorschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_invite
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="channel"></param>
    /// <param name="users"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsInviteerrorschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Invites users to a channel.
    /// </remarks>
    public Task<ConversationsInviteerrorschema1> ConversationsInvite1(ContentType contentType,
        string? token,
        string? channel,
        string? users,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.invite"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel), new Param("users", users)]),
            JsonResponse.Create<ConversationsInviteerrorschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_join
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>channels:write</c></param>
    /// <param name="channel"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsJoinsuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Joins an existing conversation.
    /// </remarks>
    public Task<ConversationsJoinsuccessschema> ConversationsJoin(ContentType contentType,
        string? token,
        string? channel,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.join"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel)]),
            JsonResponse.Create<ConversationsJoinsuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_join
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>channels:write</c></param>
    /// <param name="channel"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsJoinsuccessschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Joins an existing conversation.
    /// </remarks>
    public Task<ConversationsJoinsuccessschema1> ConversationsJoin1(ContentType contentType,
        string? token,
        string? channel,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.join"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel)]),
            JsonResponse.Create<ConversationsJoinsuccessschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_kick
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="channel"></param>
    /// <param name="user"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsKicksuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes a user from a conversation.
    /// </remarks>
    public Task<ConversationsKicksuccessschema> ConversationsKick(ContentType contentType,
        string? token,
        string? channel,
        string? user,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.kick"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel), new Param("user", user)]),
            JsonResponse.Create<ConversationsKicksuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_kick
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="channel"></param>
    /// <param name="user"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsKicksuccessschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes a user from a conversation.
    /// </remarks>
    public Task<ConversationsKicksuccessschema1> ConversationsKick1(ContentType contentType,
        string? token,
        string? channel,
        string? user,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.kick"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel), new Param("user", user)]),
            JsonResponse.Create<ConversationsKicksuccessschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_leave
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="channel"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsLeavesuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Leaves a conversation.
    /// </remarks>
    public Task<ConversationsLeavesuccessschema> ConversationsLeave(ContentType contentType,
        string? token,
        string? channel,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.leave"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel)]),
            JsonResponse.Create<ConversationsLeavesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_leave
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="channel"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsLeavesuccessschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Leaves a conversation.
    /// </remarks>
    public Task<ConversationsLeavesuccessschema1> ConversationsLeave1(ContentType contentType,
        string? token,
        string? channel,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.leave"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel)]),
            JsonResponse.Create<ConversationsLeavesuccessschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:read</c></param>
    /// <param name="excludeArchived">Set to <c>true</c> to exclude archived channels from the list</param>
    /// <param name="types">Mix and match channel types by providing a comma-separated list of any combination of <c>public_channel</c>, <c>private_channel</c>, <c>mpim</c>, <c>im</c></param>
    /// <param name="limit">The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the list hasn't been reached. Must be an integer no larger than 1000.</param>
    /// <param name="cursor">Paginate through collections of data by setting the <c>cursor</c> parameter to a <c>next_cursor</c> attribute returned by a previous request's <c>response_metadata</c>. Default value fetches the first "page" of the collection.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsListsuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists all channels in a Slack team.
    /// </remarks>
    public Task<ConversationsListsuccessschema> ConversationsList(string? token,
        bool? excludeArchived,
        string? types,
        int? limit,
        string? cursor,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.list"),
            [],
            [new Param("token", token),
                new Param("exclude_archived", excludeArchived),
                new Param("types", types),
                new Param("limit", limit),
                new Param("cursor", cursor)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ConversationsListsuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:read</c></param>
    /// <param name="excludeArchived">Set to <c>true</c> to exclude archived channels from the list</param>
    /// <param name="types">Mix and match channel types by providing a comma-separated list of any combination of <c>public_channel</c>, <c>private_channel</c>, <c>mpim</c>, <c>im</c></param>
    /// <param name="limit">The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the list hasn't been reached. Must be an integer no larger than 1000.</param>
    /// <param name="cursor">Paginate through collections of data by setting the <c>cursor</c> parameter to a <c>next_cursor</c> attribute returned by a previous request's <c>response_metadata</c>. Default value fetches the first "page" of the collection.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsListsuccessschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists all channels in a Slack team.
    /// </remarks>
    public Task<ConversationsListsuccessschema1> ConversationsList1(string? token,
        bool? excludeArchived,
        string? types,
        int? limit,
        string? cursor,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.list"),
            [],
            [new Param("token", token),
                new Param("exclude_archived", excludeArchived),
                new Param("types", types),
                new Param("limit", limit),
                new Param("cursor", cursor)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ConversationsListsuccessschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_mark
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="channel"></param>
    /// <param name="ts"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsMarksuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sets the read cursor in a channel.
    /// </remarks>
    public Task<ConversationsMarksuccessschema> ConversationsMark(ContentType contentType,
        string? token,
        string? channel,
        double? ts,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.mark"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel), new Param("ts", ts)]),
            JsonResponse.Create<ConversationsMarksuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_mark
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="channel"></param>
    /// <param name="ts"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsMarksuccessschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sets the read cursor in a channel.
    /// </remarks>
    public Task<ConversationsMarksuccessschema1> ConversationsMark1(ContentType contentType,
        string? token,
        string? channel,
        double? ts,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.mark"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel), new Param("ts", ts)]),
            JsonResponse.Create<ConversationsMarksuccessschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_members
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:read</c></param>
    /// <param name="channel">ID of the conversation to retrieve members for</param>
    /// <param name="limit">The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the users list hasn't been reached.</param>
    /// <param name="cursor">Paginate through collections of data by setting the <c>cursor</c> parameter to a <c>next_cursor</c> attribute returned by a previous request's <c>response_metadata</c>. Default value fetches the first "page" of the collection.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsMemberssuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve members of a conversation.
    /// </remarks>
    public Task<ConversationsMemberssuccessschema> ConversationsMembers(string? token,
        string? channel,
        int? limit,
        string? cursor,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.members"),
            [],
            [new Param("token", token),
                new Param("channel", channel),
                new Param("limit", limit),
                new Param("cursor", cursor)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ConversationsMemberssuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_members
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:read</c></param>
    /// <param name="channel">ID of the conversation to retrieve members for</param>
    /// <param name="limit">The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the users list hasn't been reached.</param>
    /// <param name="cursor">Paginate through collections of data by setting the <c>cursor</c> parameter to a <c>next_cursor</c> attribute returned by a previous request's <c>response_metadata</c>. Default value fetches the first "page" of the collection.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsMemberssuccessschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve members of a conversation.
    /// </remarks>
    public Task<ConversationsMemberssuccessschema1> ConversationsMembers1(string? token,
        string? channel,
        int? limit,
        string? cursor,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.members"),
            [],
            [new Param("token", token),
                new Param("channel", channel),
                new Param("limit", limit),
                new Param("cursor", cursor)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ConversationsMemberssuccessschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_open
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="channel"></param>
    /// <param name="users"></param>
    /// <param name="returnIm"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsOpensuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Opens or resumes a direct message or multi-person direct message.
    /// </remarks>
    public Task<ConversationsOpensuccessschema> ConversationsOpen(ContentType contentType,
        string? token,
        string? channel,
        string? users,
        bool? returnIm,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.open"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel),
                    new Param("users", users),
                    new Param("return_im", returnIm)]),
            JsonResponse.Create<ConversationsOpensuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_open
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="channel"></param>
    /// <param name="users"></param>
    /// <param name="returnIm"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsOpensuccessschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Opens or resumes a direct message or multi-person direct message.
    /// </remarks>
    public Task<ConversationsOpensuccessschema1> ConversationsOpen1(ContentType contentType,
        string? token,
        string? channel,
        string? users,
        bool? returnIm,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.open"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel),
                    new Param("users", users),
                    new Param("return_im", returnIm)]),
            JsonResponse.Create<ConversationsOpensuccessschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_rename
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="channel"></param>
    /// <param name="name"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsRenamesuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Renames a conversation.
    /// </remarks>
    public Task<ConversationsRenamesuccessschema> ConversationsRename(ContentType contentType,
        string? token,
        string? channel,
        string? name,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.rename"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel), new Param("name", name)]),
            JsonResponse.Create<ConversationsRenamesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_rename
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="channel"></param>
    /// <param name="name"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsRenamesuccessschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Renames a conversation.
    /// </remarks>
    public Task<ConversationsRenamesuccessschema1> ConversationsRename1(ContentType contentType,
        string? token,
        string? channel,
        string? name,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.rename"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel), new Param("name", name)]),
            JsonResponse.Create<ConversationsRenamesuccessschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_replies
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:history</c></param>
    /// <param name="channel">Conversation ID to fetch thread from.</param>
    /// <param name="ts">Unique identifier of a thread's parent message. <c>ts</c> must be the timestamp of an existing message with 0 or more replies. If there are no replies then just the single message referenced by <c>ts</c> will return - it is just an ordinary, unthreaded message.</param>
    /// <param name="latest">End of time range of messages to include in results.</param>
    /// <param name="oldest">Start of time range of messages to include in results.</param>
    /// <param name="inclusive">Include messages with latest or oldest timestamp in results only when either timestamp is specified.</param>
    /// <param name="limit">The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the users list hasn't been reached.</param>
    /// <param name="cursor">Paginate through collections of data by setting the <c>cursor</c> parameter to a <c>next_cursor</c> attribute returned by a previous request's <c>response_metadata</c>. Default value fetches the first "page" of the collection.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsRepliessuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve a thread of messages posted to a conversation
    /// </remarks>
    public Task<ConversationsRepliessuccessschema> ConversationsReplies(string? token,
        string? channel,
        double? ts,
        double? latest,
        double? oldest,
        bool? inclusive,
        int? limit,
        string? cursor,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.replies"),
            [],
            [new Param("token", token),
                new Param("channel", channel),
                new Param("ts", ts),
                new Param("latest", latest),
                new Param("oldest", oldest),
                new Param("inclusive", inclusive),
                new Param("limit", limit),
                new Param("cursor", cursor)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ConversationsRepliessuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_replies
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:history</c></param>
    /// <param name="channel">Conversation ID to fetch thread from.</param>
    /// <param name="ts">Unique identifier of a thread's parent message. <c>ts</c> must be the timestamp of an existing message with 0 or more replies. If there are no replies then just the single message referenced by <c>ts</c> will return - it is just an ordinary, unthreaded message.</param>
    /// <param name="latest">End of time range of messages to include in results.</param>
    /// <param name="oldest">Start of time range of messages to include in results.</param>
    /// <param name="inclusive">Include messages with latest or oldest timestamp in results only when either timestamp is specified.</param>
    /// <param name="limit">The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the users list hasn't been reached.</param>
    /// <param name="cursor">Paginate through collections of data by setting the <c>cursor</c> parameter to a <c>next_cursor</c> attribute returned by a previous request's <c>response_metadata</c>. Default value fetches the first "page" of the collection.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsRepliessuccessschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve a thread of messages posted to a conversation
    /// </remarks>
    public Task<ConversationsRepliessuccessschema1> ConversationsReplies1(string? token,
        string? channel,
        double? ts,
        double? latest,
        double? oldest,
        bool? inclusive,
        int? limit,
        string? cursor,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.replies"),
            [],
            [new Param("token", token),
                new Param("channel", channel),
                new Param("ts", ts),
                new Param("latest", latest),
                new Param("oldest", oldest),
                new Param("inclusive", inclusive),
                new Param("limit", limit),
                new Param("cursor", cursor)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ConversationsRepliessuccessschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_setPurpose
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="channel"></param>
    /// <param name="purpose"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsSetPurposesuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sets the purpose for a conversation.
    /// </remarks>
    public Task<ConversationsSetPurposesuccessschema> ConversationsSetPurpose(ContentType contentType,
        string? token,
        string? channel,
        string? purpose,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.setPurpose"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel), new Param("purpose", purpose)]),
            JsonResponse.Create<ConversationsSetPurposesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_setPurpose
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="channel"></param>
    /// <param name="purpose"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsSetPurposesuccessschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sets the purpose for a conversation.
    /// </remarks>
    public Task<ConversationsSetPurposesuccessschema1> ConversationsSetPurpose1(ContentType contentType,
        string? token,
        string? channel,
        string? purpose,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.setPurpose"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel), new Param("purpose", purpose)]),
            JsonResponse.Create<ConversationsSetPurposesuccessschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_setTopic
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="channel"></param>
    /// <param name="topic"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsSetTopicsuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sets the topic for a conversation.
    /// </remarks>
    public Task<ConversationsSetTopicsuccessschema> ConversationsSetTopic(ContentType contentType,
        string? token,
        string? channel,
        string? topic,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.setTopic"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel), new Param("topic", topic)]),
            JsonResponse.Create<ConversationsSetTopicsuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_setTopic
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="channel"></param>
    /// <param name="topic"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsSetTopicsuccessschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sets the topic for a conversation.
    /// </remarks>
    public Task<ConversationsSetTopicsuccessschema1> ConversationsSetTopic1(ContentType contentType,
        string? token,
        string? channel,
        string? topic,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.setTopic"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel), new Param("topic", topic)]),
            JsonResponse.Create<ConversationsSetTopicsuccessschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_unarchive
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="channel"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsUnarchivesuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Reverses conversation archival.
    /// </remarks>
    public Task<ConversationsUnarchivesuccessschema> ConversationsUnarchive(ContentType contentType,
        string? token,
        string? channel,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.unarchive"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel)]),
            JsonResponse.Create<ConversationsUnarchivesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// conversations_unarchive
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:write</c></param>
    /// <param name="channel"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsUnarchivesuccessschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Reverses conversation archival.
    /// </remarks>
    public Task<ConversationsUnarchivesuccessschema1> ConversationsUnarchive1(ContentType contentType,
        string? token,
        string? channel,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/conversations.unarchive"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel)]),
            JsonResponse.Create<ConversationsUnarchivesuccessschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
