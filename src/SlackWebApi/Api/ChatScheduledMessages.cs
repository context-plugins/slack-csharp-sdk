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
using SlackWebApi.Requests.ChatScheduledMessages;

namespace SlackWebApi.Api;

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
}
