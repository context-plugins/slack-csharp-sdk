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

public sealed class Views
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Views(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// views_open
    /// </summary>
    /// <param name="triggerId">Exchange a trigger to post to the user.</param>
    /// <param name="view">A <see href="/reference/surfaces/views">view payload</see>. This must be a JSON-encoded string.</param>
    /// <param name="token">Authentication token. Requires scope: <c>none</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Open a view for a user.
    /// </remarks>
    public Task<Defaultsuccesstemplate> ViewsOpen(string triggerId,
        string view,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/views.open"),
            [],
            [new Param("trigger_id", triggerId), new Param("view", view)],
            [new HeaderParam("token", token), new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// views_publish
    /// </summary>
    /// <param name="userId"><c>id</c> of the user you want publish a view to.</param>
    /// <param name="view">A <see href="/reference/surfaces/views">view payload</see>. This must be a JSON-encoded string.</param>
    /// <param name="hash">A string that represents view state to protect against possible race conditions.</param>
    /// <param name="token">Authentication token. Requires scope: <c>none</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Publish a static view for a User.
    /// </remarks>
    public Task<Defaultsuccesstemplate> ViewsPublish(string userId,
        string view,
        string? hash,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/views.publish"),
            [],
            [new Param("user_id", userId), new Param("view", view), new Param("hash", hash)],
            [new HeaderParam("token", token), new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// views_push
    /// </summary>
    /// <param name="triggerId">Exchange a trigger to post to the user.</param>
    /// <param name="view">A <see href="/reference/surfaces/views">view payload</see>. This must be a JSON-encoded string.</param>
    /// <param name="token">Authentication token. Requires scope: <c>none</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Push a view onto the stack of a root view.
    /// </remarks>
    public Task<Defaultsuccesstemplate> ViewsPush(string triggerId,
        string view,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/views.push"),
            [],
            [new Param("trigger_id", triggerId), new Param("view", view)],
            [new HeaderParam("token", token), new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// views_update
    /// </summary>
    /// <param name="viewId">A unique identifier of the view to be updated. Either <c>view_id</c> or <c>external_id</c> is required.</param>
    /// <param name="externalId">A unique identifier of the view set by the developer. Must be unique for all views on a team. Max length of 255 characters. Either <c>view_id</c> or <c>external_id</c> is required.</param>
    /// <param name="view">A <see href="/reference/surfaces/views">view object</see>. This must be a JSON-encoded string.</param>
    /// <param name="hash">A string that represents view state to protect against possible race conditions.</param>
    /// <param name="token">Authentication token. Requires scope: <c>none</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an existing view.
    /// </remarks>
    public Task<Defaultsuccesstemplate> ViewsUpdate(string? viewId,
        string? externalId,
        string? view,
        string? hash,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/views.update"),
            [],
            [new Param("view_id", viewId),
                new Param("external_id", externalId),
                new Param("view", view),
                new Param("hash", hash)],
            [new HeaderParam("token", token), new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
