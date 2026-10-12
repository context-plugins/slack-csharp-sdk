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
using SlackWebApi.Requests.Dialog;

namespace SlackWebApi.Api;

public sealed class Dialog
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Dialog(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// dialog_open
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DialogOpenschema"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Open a dialog with a user
    /// </remarks>
    public Task<DialogOpenschema> DialogOpen(DialogOpenRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/dialog.open"),
            [],
            [new Param("dialog", request.Dialog), new Param("trigger_id", request.TriggerId)],
            [new HeaderParam("token", request.Token), new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DialogOpenschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);
}
