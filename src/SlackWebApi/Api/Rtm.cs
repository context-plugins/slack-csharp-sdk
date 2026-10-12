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
using SlackWebApi.Requests.Rtm;

namespace SlackWebApi.Api;

public sealed class Rtm
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Rtm(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// rtm_connect
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RtmConnectschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Starts a Real Time Messaging session.
    /// </remarks>
    public Task<RtmConnectschema> RtmConnect(RtmConnectRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/rtm.connect"),
            [],
            [
                new Param("token", request.Token),
                new Param("batch_presence_aware", request.BatchPresenceAware),
                new Param("presence_sub", request.PresenceSub),
            ],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RtmConnectschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);
}
