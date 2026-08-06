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
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>chat:write</c></param>
    /// <param name="ts"></param>
    /// <param name="channel"></param>
    /// <param name="asUser"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChatDeletesuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a message.
    /// </remarks>
    public Task<ChatDeletesuccessschema> ChatDelete(ContentType contentType,
        string? token,
        double? ts,
        string? channel,
        bool? asUser,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/chat.delete"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("ts", ts),
                    new Param("channel", channel),
                    new Param("as_user", asUser)]),
            JsonResponse.Create<ChatDeletesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// chat_deleteScheduledMessage
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>chat:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="channel"></param>
    /// <param name="scheduledMessageId"></param>
    /// <param name="asUser"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChatDeleteScheduledMessageschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a pending scheduled message from the queue.
    /// </remarks>
    public Task<ChatDeleteScheduledMessageschema> ChatDeleteScheduledMessage(string token,
        ContentType contentType,
        string channel,
        string scheduledMessageId,
        bool? asUser,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/chat.deleteScheduledMessage"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel),
                    new Param("scheduled_message_id", scheduledMessageId),
                    new Param("as_user", asUser)]),
            JsonResponse.Create<ChatDeleteScheduledMessageschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// chat_getPermalink
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>none</c></param>
    /// <param name="channel">The ID of the conversation or channel containing the message</param>
    /// <param name="messageTs">A message's <c>ts</c> value, uniquely identifying it within a channel</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChatGetPermalinksuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve a permalink URL for a specific extant message
    /// </remarks>
    public Task<ChatGetPermalinksuccessschema> ChatGetPermalink(string token,
        string channel,
        string messageTs,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/chat.getPermalink"),
            [],
            [new Param("token", token), new Param("channel", channel), new Param("message_ts", messageTs)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ChatGetPermalinksuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// chat_meMessage
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>chat:write</c></param>
    /// <param name="channel"></param>
    /// <param name="text"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChatMeMessageschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Share a me message into a channel.
    /// </remarks>
    public Task<ChatMeMessageschema> ChatMeMessage(ContentType contentType,
        string? token,
        string? channel,
        string? text,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/chat.meMessage"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel), new Param("text", text)]),
            JsonResponse.Create<ChatMeMessageschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// chat_postEphemeral
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>chat:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="channel"></param>
    /// <param name="user"></param>
    /// <param name="asUser"></param>
    /// <param name="attachments"></param>
    /// <param name="blocks"></param>
    /// <param name="iconEmoji"></param>
    /// <param name="iconUrl"></param>
    /// <param name="linkNames"></param>
    /// <param name="parse"></param>
    /// <param name="text"></param>
    /// <param name="threadTs"></param>
    /// <param name="username"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChatPostEphemeralsuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends an ephemeral message to a user in a channel.
    /// </remarks>
    public Task<ChatPostEphemeralsuccessschema> ChatPostEphemeral(string token,
        ContentType contentType,
        string channel,
        string user,
        bool? asUser,
        string? attachments,
        string? blocks,
        string? iconEmoji,
        string? iconUrl,
        bool? linkNames,
        string? parse,
        string? text,
        string? threadTs,
        string? username,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/chat.postEphemeral"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel),
                    new Param("user", user),
                    new Param("as_user", asUser),
                    new Param("attachments", attachments),
                    new Param("blocks", blocks),
                    new Param("icon_emoji", iconEmoji),
                    new Param("icon_url", iconUrl),
                    new Param("link_names", linkNames),
                    new Param("parse", parse),
                    new Param("text", text),
                    new Param("thread_ts", threadTs),
                    new Param("username", username)]),
            JsonResponse.Create<ChatPostEphemeralsuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// chat_postMessage
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>chat:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="channel"></param>
    /// <param name="asUser"></param>
    /// <param name="attachments"></param>
    /// <param name="blocks"></param>
    /// <param name="iconEmoji"></param>
    /// <param name="iconUrl"></param>
    /// <param name="linkNames"></param>
    /// <param name="mrkdwn"></param>
    /// <param name="parse"></param>
    /// <param name="replyBroadcast"></param>
    /// <param name="text"></param>
    /// <param name="threadTs"></param>
    /// <param name="unfurlLinks"></param>
    /// <param name="unfurlMedia"></param>
    /// <param name="username"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChatPostMessagesuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends a message to a channel.
    /// </remarks>
    public Task<ChatPostMessagesuccessschema> ChatPostMessage(string token,
        ContentType contentType,
        string channel,
        string? asUser,
        string? attachments,
        string? blocks,
        string? iconEmoji,
        string? iconUrl,
        bool? linkNames,
        bool? mrkdwn,
        string? parse,
        bool? replyBroadcast,
        string? text,
        string? threadTs,
        bool? unfurlLinks,
        bool? unfurlMedia,
        string? username,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/chat.postMessage"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel),
                    new Param("as_user", asUser),
                    new Param("attachments", attachments),
                    new Param("blocks", blocks),
                    new Param("icon_emoji", iconEmoji),
                    new Param("icon_url", iconUrl),
                    new Param("link_names", linkNames),
                    new Param("mrkdwn", mrkdwn),
                    new Param("parse", parse),
                    new Param("reply_broadcast", replyBroadcast),
                    new Param("text", text),
                    new Param("thread_ts", threadTs),
                    new Param("unfurl_links", unfurlLinks),
                    new Param("unfurl_media", unfurlMedia),
                    new Param("username", username)]),
            JsonResponse.Create<ChatPostMessagesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// chat_scheduleMessage
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>chat:write</c></param>
    /// <param name="channel"></param>
    /// <param name="text"></param>
    /// <param name="postAt"></param>
    /// <param name="parse"></param>
    /// <param name="asUser"></param>
    /// <param name="linkNames"></param>
    /// <param name="attachments"></param>
    /// <param name="blocks"></param>
    /// <param name="unfurlLinks"></param>
    /// <param name="unfurlMedia"></param>
    /// <param name="threadTs"></param>
    /// <param name="replyBroadcast"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChatScheduleMessagesuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Schedules a message to be sent to a channel.
    /// </remarks>
    public Task<ChatScheduleMessagesuccessschema> ChatScheduleMessage(ContentType contentType,
        string? token,
        string? channel,
        string? text,
        string? postAt,
        string? parse,
        bool? asUser,
        bool? linkNames,
        string? attachments,
        string? blocks,
        bool? unfurlLinks,
        bool? unfurlMedia,
        double? threadTs,
        bool? replyBroadcast,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/chat.scheduleMessage"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel),
                    new Param("text", text),
                    new Param("post_at", postAt),
                    new Param("parse", parse),
                    new Param("as_user", asUser),
                    new Param("link_names", linkNames),
                    new Param("attachments", attachments),
                    new Param("blocks", blocks),
                    new Param("unfurl_links", unfurlLinks),
                    new Param("unfurl_media", unfurlMedia),
                    new Param("thread_ts", threadTs),
                    new Param("reply_broadcast", replyBroadcast)]),
            JsonResponse.Create<ChatScheduleMessagesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// chat_scheduledMessages_list
    /// </summary>
    /// <param name="channel">The channel of the scheduled messages</param>
    /// <param name="latest">A UNIX timestamp of the latest value in the time range</param>
    /// <param name="oldest">A UNIX timestamp of the oldest value in the time range</param>
    /// <param name="limit">Maximum number of original entries to return.</param>
    /// <param name="cursor">For pagination purposes, this is the <c>cursor</c> value returned from a previous call to <c>chat.scheduledmessages.list</c> indicating where you want to start this call from.</param>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>none</c></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChatScheduledMessagesListschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of scheduled messages.
    /// </remarks>
    public Task<ChatScheduledMessagesListschema> ChatScheduledMessagesList(string? channel,
        double? latest,
        double? oldest,
        int? limit,
        string? cursor,
        ContentType contentType,
        string? token,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/chat.scheduledMessages.list"),
            [],
            [new Param("channel", channel),
                new Param("latest", latest),
                new Param("oldest", oldest),
                new Param("limit", limit),
                new Param("cursor", cursor)],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("token", token)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ChatScheduledMessagesListschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// chat_unfurl
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>links:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="channel"></param>
    /// <param name="ts"></param>
    /// <param name="unfurls"></param>
    /// <param name="userAuthMessage"></param>
    /// <param name="userAuthRequired"></param>
    /// <param name="userAuthUrl"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChatUnfurlsuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provide custom unfurl behavior for user-posted URLs
    /// </remarks>
    public Task<ChatUnfurlsuccessschema> ChatUnfurl(string token,
        ContentType contentType,
        string channel,
        string ts,
        string? unfurls,
        string? userAuthMessage,
        bool? userAuthRequired,
        string? userAuthUrl,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/chat.unfurl"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel),
                    new Param("ts", ts),
                    new Param("unfurls", unfurls),
                    new Param("user_auth_message", userAuthMessage),
                    new Param("user_auth_required", userAuthRequired),
                    new Param("user_auth_url", userAuthUrl)]),
            JsonResponse.Create<ChatUnfurlsuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// chat_update
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>chat:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="channel"></param>
    /// <param name="ts"></param>
    /// <param name="asUser"></param>
    /// <param name="attachments"></param>
    /// <param name="blocks"></param>
    /// <param name="linkNames"></param>
    /// <param name="parse"></param>
    /// <param name="text"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChatUpdatesuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a message.
    /// </remarks>
    public Task<ChatUpdatesuccessschema> ChatUpdate(string token,
        ContentType contentType,
        string channel,
        string ts,
        string? asUser,
        string? attachments,
        string? blocks,
        string? linkNames,
        string? parse,
        string? text,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/chat.update"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel),
                    new Param("ts", ts),
                    new Param("as_user", asUser),
                    new Param("attachments", attachments),
                    new Param("blocks", blocks),
                    new Param("link_names", linkNames),
                    new Param("parse", parse),
                    new Param("text", text)]),
            JsonResponse.Create<ChatUpdatesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
