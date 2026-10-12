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
using SlackWebApi.Requests.Conversations;

namespace SlackWebApi.Api;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsArchivesuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Archives a conversation.
    /// </remarks>
    public Task<ConversationsArchivesuccessschema> ConversationsArchive(ConversationsArchiveRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/conversations.archive"),
            [],
            [],
            [
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("token", request.Token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("channel", request.Channel)),
            JsonResponse.Create<ConversationsArchivesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// conversations_close
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsClosesuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Closes a direct message or multi-person direct message.
    /// </remarks>
    public Task<ConversationsClosesuccessschema> ConversationsClose(ConversationsCloseRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/conversations.close"),
            [],
            [],
            [
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("token", request.Token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("channel", request.Channel)),
            JsonResponse.Create<ConversationsClosesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// conversations_create
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsCreatesuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Initiates a public or private channel-based conversation
    /// </remarks>
    public Task<ConversationsCreatesuccessschema> ConversationsCreate(ConversationsCreateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/conversations.create"),
            [],
            [],
            [
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("token", request.Token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("name", request.Name), new Param("is_private", request.IsPrivate)),
            JsonResponse.Create<ConversationsCreatesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// conversations_history
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsHistorysuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetches a conversation's history of messages and events.
    /// </remarks>
    public Task<ConversationsHistorysuccessschema> ConversationsHistory(ConversationsHistoryRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/conversations.history"),
            [],
            [
                new Param("token", request.Token),
                new Param("channel", request.Channel),
                new Param("latest", request.Latest),
                new Param("oldest", request.Oldest),
                new Param("inclusive", request.Inclusive),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
            ],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ConversationsHistorysuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// conversations_info
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsInfosuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve information about a conversation.
    /// </remarks>
    public Task<ConversationsInfosuccessschema> ConversationsInfo(ConversationsInfoRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/conversations.info"),
            [],
            [
                new Param("token", request.Token),
                new Param("channel", request.Channel),
                new Param("include_locale", request.IncludeLocale),
                new Param("include_num_members", request.IncludeNumMembers),
            ],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ConversationsInfosuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// conversations_invite
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsInviteerrorschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Invites users to a channel.
    /// </remarks>
    public Task<ConversationsInviteerrorschema> ConversationsInvite(ConversationsInviteRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/conversations.invite"),
            [],
            [],
            [
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("token", request.Token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("channel", request.Channel), new Param("users", request.Users)),
            JsonResponse.Create<ConversationsInviteerrorschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// conversations_join
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsJoinsuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Joins an existing conversation.
    /// </remarks>
    public Task<ConversationsJoinsuccessschema> ConversationsJoin(ConversationsJoinRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/conversations.join"),
            [],
            [],
            [
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("token", request.Token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("channel", request.Channel)),
            JsonResponse.Create<ConversationsJoinsuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// conversations_kick
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsKicksuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes a user from a conversation.
    /// </remarks>
    public Task<ConversationsKicksuccessschema> ConversationsKick(ConversationsKickRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/conversations.kick"),
            [],
            [],
            [
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("token", request.Token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("channel", request.Channel), new Param("user", request.User)),
            JsonResponse.Create<ConversationsKicksuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// conversations_leave
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsLeavesuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Leaves a conversation.
    /// </remarks>
    public Task<ConversationsLeavesuccessschema> ConversationsLeave(ConversationsLeaveRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/conversations.leave"),
            [],
            [],
            [
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("token", request.Token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("channel", request.Channel)),
            JsonResponse.Create<ConversationsLeavesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// conversations_list
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsListsuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists all channels in a Slack team.
    /// </remarks>
    public Task<ConversationsListsuccessschema> ConversationsList(ConversationsListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/conversations.list"),
            [],
            [
                new Param("token", request.Token),
                new Param("exclude_archived", request.ExcludeArchived),
                new Param("types", request.Types),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
            ],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ConversationsListsuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// conversations_mark
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsMarksuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sets the read cursor in a channel.
    /// </remarks>
    public Task<ConversationsMarksuccessschema> ConversationsMark(ConversationsMarkRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/conversations.mark"),
            [],
            [],
            [
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("token", request.Token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("channel", request.Channel), new Param("ts", request.Ts)),
            JsonResponse.Create<ConversationsMarksuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// conversations_members
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsMemberssuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve members of a conversation.
    /// </remarks>
    public Task<ConversationsMemberssuccessschema> ConversationsMembers(ConversationsMembersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/conversations.members"),
            [],
            [
                new Param("token", request.Token),
                new Param("channel", request.Channel),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
            ],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ConversationsMemberssuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// conversations_open
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsOpensuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Opens or resumes a direct message or multi-person direct message.
    /// </remarks>
    public Task<ConversationsOpensuccessschema> ConversationsOpen(ConversationsOpenRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/conversations.open"),
            [],
            [],
            [
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("token", request.Token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("channel", request.Channel),
                new Param("users", request.Users),
                new Param("return_im", request.ReturnIm)),
            JsonResponse.Create<ConversationsOpensuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// conversations_rename
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsRenamesuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Renames a conversation.
    /// </remarks>
    public Task<ConversationsRenamesuccessschema> ConversationsRename(ConversationsRenameRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/conversations.rename"),
            [],
            [],
            [
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("token", request.Token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("channel", request.Channel), new Param("name", request.Name)),
            JsonResponse.Create<ConversationsRenamesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// conversations_replies
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsRepliessuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve a thread of messages posted to a conversation
    /// </remarks>
    public Task<ConversationsRepliessuccessschema> ConversationsReplies(ConversationsRepliesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/conversations.replies"),
            [],
            [
                new Param("token", request.Token),
                new Param("channel", request.Channel),
                new Param("ts", request.Ts),
                new Param("latest", request.Latest),
                new Param("oldest", request.Oldest),
                new Param("inclusive", request.Inclusive),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
            ],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ConversationsRepliessuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// conversations_setPurpose
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsSetPurposesuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sets the purpose for a conversation.
    /// </remarks>
    public Task<ConversationsSetPurposesuccessschema> ConversationsSetPurpose(ConversationsSetPurposeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/conversations.setPurpose"),
            [],
            [],
            [
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("token", request.Token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("channel", request.Channel), new Param("purpose", request.Purpose)),
            JsonResponse.Create<ConversationsSetPurposesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// conversations_setTopic
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsSetTopicsuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sets the topic for a conversation.
    /// </remarks>
    public Task<ConversationsSetTopicsuccessschema> ConversationsSetTopic(ConversationsSetTopicRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/conversations.setTopic"),
            [],
            [],
            [
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("token", request.Token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("channel", request.Channel), new Param("topic", request.Topic)),
            JsonResponse.Create<ConversationsSetTopicsuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// conversations_unarchive
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConversationsUnarchivesuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Reverses conversation archival.
    /// </remarks>
    public Task<ConversationsUnarchivesuccessschema> ConversationsUnarchive(ConversationsUnarchiveRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/conversations.unarchive"),
            [],
            [],
            [
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("token", request.Token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("channel", request.Channel)),
            JsonResponse.Create<ConversationsUnarchivesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);
}
