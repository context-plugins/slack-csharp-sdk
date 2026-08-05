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

public sealed class AdminEmoji
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AdminEmoji(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// admin_emoji_add
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="name"></param>
    /// <param name="url"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Add an emoji.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminEmojiAdd(ContentType contentType,
        string token,
        string name,
        string url,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.emoji.add"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token),
                    new Param("name", name),
                    new Param("url", url)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_emoji_add
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="name"></param>
    /// <param name="url"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Add an emoji.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AdminEmojiAdd1(ContentType contentType,
        string token,
        string name,
        string url,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.emoji.add"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token),
                    new Param("name", name),
                    new Param("url", url)]),
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_emoji_addAlias
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="name"></param>
    /// <param name="aliasFor"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Add an emoji alias.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminEmojiAddAlias(ContentType contentType,
        string token,
        string name,
        string aliasFor,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.emoji.addAlias"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token),
                    new Param("name", name),
                    new Param("alias_for", aliasFor)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_emoji_addAlias
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="name"></param>
    /// <param name="aliasFor"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Add an emoji alias.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AdminEmojiAddAlias1(ContentType contentType,
        string token,
        string name,
        string aliasFor,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.emoji.addAlias"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token),
                    new Param("name", name),
                    new Param("alias_for", aliasFor)]),
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_emoji_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.teams:read</c></param>
    /// <param name="cursor">Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page</param>
    /// <param name="limit">The maximum number of items to return. Must be between 1 - 1000 both inclusive.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List emoji for an Enterprise Grid organization.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminEmojiList(string token,
        string? cursor,
        int? limit,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.emoji.list"),
            [],
            [new Param("token", token), new Param("cursor", cursor), new Param("limit", limit)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_emoji_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.teams:read</c></param>
    /// <param name="cursor">Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page</param>
    /// <param name="limit">The maximum number of items to return. Must be between 1 - 1000 both inclusive.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List emoji for an Enterprise Grid organization.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AdminEmojiList1(string token,
        string? cursor,
        int? limit,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.emoji.list"),
            [],
            [new Param("token", token), new Param("cursor", cursor), new Param("limit", limit)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_emoji_remove
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="name"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Remove an emoji across an Enterprise Grid organization
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminEmojiRemove(ContentType contentType,
        string token,
        string name,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.emoji.remove"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token), new Param("name", name)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_emoji_remove
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="name"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Remove an emoji across an Enterprise Grid organization
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AdminEmojiRemove1(ContentType contentType,
        string token,
        string name,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.emoji.remove"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token), new Param("name", name)]),
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_emoji_rename
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="name"></param>
    /// <param name="newName"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Rename an emoji.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminEmojiRename(ContentType contentType,
        string token,
        string name,
        string newName,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.emoji.rename"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token),
                    new Param("name", name),
                    new Param("new_name", newName)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_emoji_rename
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="name"></param>
    /// <param name="newName"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Rename an emoji.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AdminEmojiRename1(ContentType contentType,
        string token,
        string name,
        string newName,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.emoji.rename"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token),
                    new Param("name", name),
                    new Param("new_name", newName)]),
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
