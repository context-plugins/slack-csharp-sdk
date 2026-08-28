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

public sealed class Reactions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Reactions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// reactions_add
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>reactions:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="channel"></param>
    /// <param name="name"></param>
    /// <param name="timestamp"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ReactionsAddschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds a reaction to an item.
    /// </remarks>
    public Task<ReactionsAddschema> ReactionsAdd(string token,
        ContentType contentType,
        string channel,
        string name,
        string timestamp,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reactions.add"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("channel", channel),
                    new Param("name", name),
                    new Param("timestamp", timestamp)]),
            JsonResponse.Create<ReactionsAddschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// reactions_get
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>reactions:read</c></param>
    /// <param name="channel">Channel where the message to get reactions for was posted.</param>
    /// <param name="file">File to get reactions for.</param>
    /// <param name="fileComment">File comment to get reactions for.</param>
    /// <param name="full">If true always return the complete reaction list.</param>
    /// <param name="timestamp">Timestamp of the message to get reactions for.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Gets reactions for an item.
    /// </remarks>
    public Task<object> ReactionsGet(string token,
        string? channel,
        string? file,
        string? fileComment,
        bool? full,
        string? timestamp,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reactions.get"),
            [],
            [new Param("token", token),
                new Param("channel", channel),
                new Param("file", file),
                new Param("file_comment", fileComment),
                new Param("full", full),
                new Param("timestamp", timestamp)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// reactions_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>reactions:read</c></param>
    /// <param name="user">Show reactions made by this user. Defaults to the authed user.</param>
    /// <param name="full">If true always return the complete reaction list.</param>
    /// <param name="count"></param>
    /// <param name="page"></param>
    /// <param name="cursor">Parameter for pagination. Set <c>cursor</c> equal to the <c>next_cursor</c> attribute returned by the previous request's <c>response_metadata</c>. This parameter is optional, but pagination is mandatory: the default value simply fetches the first "page" of the collection.</param>
    /// <param name="limit">The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the list hasn't been reached.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ReactionsListschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists reactions made by a user.
    /// </remarks>
    public Task<ReactionsListschema> ReactionsList(string token,
        string? user,
        bool? full,
        int? count,
        int? page,
        string? cursor,
        int? limit,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reactions.list"),
            [],
            [new Param("token", token),
                new Param("user", user),
                new Param("full", full),
                new Param("count", count),
                new Param("page", page),
                new Param("cursor", cursor),
                new Param("limit", limit)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ReactionsListschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// reactions_remove
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>reactions:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="name"></param>
    /// <param name="file"></param>
    /// <param name="fileComment"></param>
    /// <param name="channel"></param>
    /// <param name="timestamp"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ReactionsRemoveschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes a reaction from an item.
    /// </remarks>
    public Task<ReactionsRemoveschema> ReactionsRemove(string token,
        ContentType contentType,
        string name,
        string? file,
        string? fileComment,
        string? channel,
        string? timestamp,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reactions.remove"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("name", name),
                    new Param("file", file),
                    new Param("file_comment", fileComment),
                    new Param("channel", channel),
                    new Param("timestamp", timestamp)]),
            JsonResponse.Create<ReactionsRemoveschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
