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
    /// <param name="token">Authentication token. Requires scope: <c>rtm:stream</c></param>
    /// <param name="batchPresenceAware">Batch presence deliveries via subscription. Enabling changes the shape of <c>presence_change</c> events.</param>
    /// <param name="presenceSub">Only deliver presence events when requested by subscription</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RtmConnectschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Starts a Real Time Messaging session.
    /// </remarks>
    public Task<RtmConnectschema> RtmConnect(string token,
        bool? batchPresenceAware,
        bool? presenceSub,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/rtm.connect"),
            [],
            [new Param("token", token),
                new Param("batch_presence_aware", batchPresenceAware),
                new Param("presence_sub", presenceSub)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RtmConnectschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
