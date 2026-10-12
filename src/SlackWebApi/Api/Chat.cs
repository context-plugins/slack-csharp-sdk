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
using SlackWebApi.Requests.Chat;
using SlackWebApi.Requests.ChatScheduledMessages;

namespace SlackWebApi.Api;

public sealed class Chat
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Chat(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// chat_delete
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChatDeletesuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a message.
    /// </remarks>
    public Task<ChatDeletesuccessschema> ChatDelete(ChatDeleteRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chat.delete"),
            [],
            [],
            [
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("token", request.Token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("ts", request.Ts),
                new Param("channel", request.Channel),
                new Param("as_user", request.AsUser)),
            JsonResponse.Create<ChatDeletesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// chat_deleteScheduledMessage
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChatDeleteScheduledMessageschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a pending scheduled message from the queue.
    /// </remarks>
    public Task<ChatDeleteScheduledMessageschema> ChatDeleteScheduledMessage(ChatDeleteScheduledMessageRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chat.deleteScheduledMessage"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("channel", request.Channel),
                new Param("scheduled_message_id", request.ScheduledMessageId),
                new Param("as_user", request.AsUser)),
            JsonResponse.Create<ChatDeleteScheduledMessageschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// chat_getPermalink
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChatGetPermalinksuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve a permalink URL for a specific extant message
    /// </remarks>
    public Task<ChatGetPermalinksuccessschema> ChatGetPermalink(ChatGetPermalinkRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chat.getPermalink"),
            [],
            [
                new Param("token", request.Token),
                new Param("channel", request.Channel),
                new Param("message_ts", request.MessageTs),
            ],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ChatGetPermalinksuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// chat_meMessage
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChatMeMessageschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Share a me message into a channel.
    /// </remarks>
    public Task<ChatMeMessageschema> ChatMeMessage(ChatMeMessageRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chat.meMessage"),
            [],
            [],
            [
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("token", request.Token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(new Param("channel", request.Channel), new Param("text", request.Text)),
            JsonResponse.Create<ChatMeMessageschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// chat_postEphemeral
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChatPostEphemeralsuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends an ephemeral message to a user in a channel.
    /// </remarks>
    public Task<ChatPostEphemeralsuccessschema> ChatPostEphemeral(ChatPostEphemeralRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chat.postEphemeral"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("channel", request.Channel),
                new Param("user", request.User),
                new Param("as_user", request.AsUser),
                new Param("attachments", request.Attachments),
                new Param("blocks", request.Blocks),
                new Param("icon_emoji", request.IconEmoji),
                new Param("icon_url", request.IconUrl),
                new Param("link_names", request.LinkNames),
                new Param("parse", request.Parse),
                new Param("text", request.Text),
                new Param("thread_ts", request.ThreadTs),
                new Param("username", request.Username)),
            JsonResponse.Create<ChatPostEphemeralsuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// chat_postMessage
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChatPostMessagesuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends a message to a channel.
    /// </remarks>
    public Task<ChatPostMessagesuccessschema> ChatPostMessage(ChatPostMessageRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chat.postMessage"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("channel", request.Channel),
                new Param("as_user", request.AsUser),
                new Param("attachments", request.Attachments),
                new Param("blocks", request.Blocks),
                new Param("icon_emoji", request.IconEmoji),
                new Param("icon_url", request.IconUrl),
                new Param("link_names", request.LinkNames),
                new Param("mrkdwn", request.Mrkdwn),
                new Param("parse", request.Parse),
                new Param("reply_broadcast", request.ReplyBroadcast),
                new Param("text", request.Text),
                new Param("thread_ts", request.ThreadTs),
                new Param("unfurl_links", request.UnfurlLinks),
                new Param("unfurl_media", request.UnfurlMedia),
                new Param("username", request.Username)),
            JsonResponse.Create<ChatPostMessagesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// chat_scheduleMessage
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChatScheduleMessagesuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Schedules a message to be sent to a channel.
    /// </remarks>
    public Task<ChatScheduleMessagesuccessschema> ChatScheduleMessage(ChatScheduleMessageRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chat.scheduleMessage"),
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
                new Param("text", request.Text),
                new Param("post_at", request.PostAt),
                new Param("parse", request.Parse),
                new Param("as_user", request.AsUser),
                new Param("link_names", request.LinkNames),
                new Param("attachments", request.Attachments),
                new Param("blocks", request.Blocks),
                new Param("unfurl_links", request.UnfurlLinks),
                new Param("unfurl_media", request.UnfurlMedia),
                new Param("thread_ts", request.ThreadTs),
                new Param("reply_broadcast", request.ReplyBroadcast)),
            JsonResponse.Create<ChatScheduleMessagesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// chat_scheduledMessages_list
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChatScheduledMessagesListschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of scheduled messages.
    /// </remarks>
    public Task<ChatScheduledMessagesListschema> ChatScheduledMessagesList(ChatScheduledMessagesListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chat.scheduledMessages.list"),
            [],
            [
                new Param("channel", request.Channel),
                new Param("latest", request.Latest),
                new Param("oldest", request.Oldest),
                new Param("limit", request.Limit),
                new Param("cursor", request.Cursor),
            ],
            [new HeaderParam("Content-Type", request.ContentType), new HeaderParam("token", request.Token)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ChatScheduledMessagesListschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// chat_unfurl
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChatUnfurlsuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provide custom unfurl behavior for user-posted URLs
    /// </remarks>
    public Task<ChatUnfurlsuccessschema> ChatUnfurl(ChatUnfurlRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chat.unfurl"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("channel", request.Channel),
                new Param("ts", request.Ts),
                new Param("unfurls", request.Unfurls),
                new Param("user_auth_message", request.UserAuthMessage),
                new Param("user_auth_required", request.UserAuthRequired),
                new Param("user_auth_url", request.UserAuthUrl)),
            JsonResponse.Create<ChatUnfurlsuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// chat_update
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChatUpdatesuccessschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a message.
    /// </remarks>
    public Task<ChatUpdatesuccessschema> ChatUpdate(ChatUpdateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/chat.update"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("Content-Type", request.ContentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("channel", request.Channel),
                new Param("ts", request.Ts),
                new Param("as_user", request.AsUser),
                new Param("attachments", request.Attachments),
                new Param("blocks", request.Blocks),
                new Param("link_names", request.LinkNames),
                new Param("parse", request.Parse),
                new Param("text", request.Text)),
            JsonResponse.Create<ChatUpdatesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);
}
