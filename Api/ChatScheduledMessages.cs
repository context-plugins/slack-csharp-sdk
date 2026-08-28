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

public sealed class ChatScheduledMessages
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ChatScheduledMessages(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

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
}
