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

public sealed class Stars
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Stars(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// stars_add
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>stars:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="channel"></param>
    /// <param name="file"></param>
    /// <param name="fileComment"></param>
    /// <param name="timestamp"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StarsAddschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds a star to an item.
    /// </remarks>
    public Task<StarsAddschema> StarsAdd(string token,
        ContentType contentType,
        string? channel,
        string? file,
        string? fileComment,
        string? timestamp,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/stars.add"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel),
                    new Param("file", file),
                    new Param("file_comment", fileComment),
                    new Param("timestamp", timestamp)]),
            JsonResponse.Create<StarsAddschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// stars_add
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>stars:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="channel"></param>
    /// <param name="file"></param>
    /// <param name="fileComment"></param>
    /// <param name="timestamp"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StarsAddschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds a star to an item.
    /// </remarks>
    public Task<StarsAddschema1> StarsAdd1(string token,
        ContentType contentType,
        string? channel,
        string? file,
        string? fileComment,
        string? timestamp,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/stars.add"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel),
                    new Param("file", file),
                    new Param("file_comment", fileComment),
                    new Param("timestamp", timestamp)]),
            JsonResponse.Create<StarsAddschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// stars_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>stars:read</c></param>
    /// <param name="count"></param>
    /// <param name="page"></param>
    /// <param name="cursor">Parameter for pagination. Set <c>cursor</c> equal to the <c>next_cursor</c> attribute returned by the previous request's <c>response_metadata</c>. This parameter is optional, but pagination is mandatory: the default value simply fetches the first "page" of the collection.</param>
    /// <param name="limit">The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the list hasn't been reached.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StarsListschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists stars for a user.
    /// </remarks>
    public Task<StarsListschema> StarsList(string? token,
        string? count,
        string? page,
        string? cursor,
        int? limit,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/stars.list"),
            [],
            [new Param("token", token),
                new Param("count", count),
                new Param("page", page),
                new Param("cursor", cursor),
                new Param("limit", limit)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<StarsListschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// stars_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>stars:read</c></param>
    /// <param name="count"></param>
    /// <param name="page"></param>
    /// <param name="cursor">Parameter for pagination. Set <c>cursor</c> equal to the <c>next_cursor</c> attribute returned by the previous request's <c>response_metadata</c>. This parameter is optional, but pagination is mandatory: the default value simply fetches the first "page" of the collection.</param>
    /// <param name="limit">The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the list hasn't been reached.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StarsListschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists stars for a user.
    /// </remarks>
    public Task<StarsListschema1> StarsList1(string? token,
        string? count,
        string? page,
        string? cursor,
        int? limit,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/stars.list"),
            [],
            [new Param("token", token),
                new Param("count", count),
                new Param("page", page),
                new Param("cursor", cursor),
                new Param("limit", limit)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<StarsListschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// stars_remove
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>stars:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="channel"></param>
    /// <param name="file"></param>
    /// <param name="fileComment"></param>
    /// <param name="timestamp"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StarsRemoveschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes a star from an item.
    /// </remarks>
    public Task<StarsRemoveschema> StarsRemove(string token,
        ContentType contentType,
        string? channel,
        string? file,
        string? fileComment,
        string? timestamp,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/stars.remove"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel),
                    new Param("file", file),
                    new Param("file_comment", fileComment),
                    new Param("timestamp", timestamp)]),
            JsonResponse.Create<StarsRemoveschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// stars_remove
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>stars:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="channel"></param>
    /// <param name="file"></param>
    /// <param name="fileComment"></param>
    /// <param name="timestamp"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StarsRemoveschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes a star from an item.
    /// </remarks>
    public Task<StarsRemoveschema1> StarsRemove1(string token,
        ContentType contentType,
        string? channel,
        string? file,
        string? fileComment,
        string? timestamp,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/stars.remove"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel),
                    new Param("file", file),
                    new Param("file_comment", fileComment),
                    new Param("timestamp", timestamp)]),
            JsonResponse.Create<StarsRemoveschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
