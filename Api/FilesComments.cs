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

public sealed class FilesComments
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal FilesComments(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// files_comments_delete
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>files:write:user</c></param>
    /// <param name="file"></param>
    /// <param name="id"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FilesCommentsDeleteschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes an existing comment on a file.
    /// </remarks>
    public Task<FilesCommentsDeleteschema> FilesCommentsDelete(ContentType contentType,
        string? token,
        string? file,
        string? id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/files.comments.delete"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("file", file), new Param("id", id)]),
            JsonResponse.Create<FilesCommentsDeleteschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// files_comments_delete
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>files:write:user</c></param>
    /// <param name="file"></param>
    /// <param name="id"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FilesCommentsDeleteschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes an existing comment on a file.
    /// </remarks>
    public Task<FilesCommentsDeleteschema1> FilesCommentsDelete1(ContentType contentType,
        string? token,
        string? file,
        string? id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/files.comments.delete"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("file", file), new Param("id", id)]),
            JsonResponse.Create<FilesCommentsDeleteschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
