using System;
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
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Api;

public sealed class Files
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Files(RawClient rawClient, Server server, AuthSchemes auth)
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
    /// files_delete
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>files:write:user</c></param>
    /// <param name="file"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FilesDeleteschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a file.
    /// </remarks>
    public Task<FilesDeleteschema> FilesDelete(ContentType contentType,
        string? token,
        string? file,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/files.delete"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("file", file)]),
            JsonResponse.Create<FilesDeleteschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// files_info
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>files:read</c></param>
    /// <param name="file">Specify a file by providing its ID.</param>
    /// <param name="count"></param>
    /// <param name="page"></param>
    /// <param name="limit">The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the list hasn't been reached.</param>
    /// <param name="cursor">Parameter for pagination. File comments are paginated for a single file. Set <c>cursor</c> equal to the <c>next_cursor</c> attribute returned by the previous request's <c>response_metadata</c>. This parameter is optional, but pagination is mandatory: the default value simply fetches the first "page" of the collection of comments.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FilesInfoschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Gets information about a file.
    /// </remarks>
    public Task<FilesInfoschema> FilesInfo(string? token,
        string? file,
        string? count,
        string? page,
        int? limit,
        string? cursor,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/files.info"),
            [],
            [new Param("token", token),
                new Param("file", file),
                new Param("count", count),
                new Param("page", page),
                new Param("limit", limit),
                new Param("cursor", cursor)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FilesInfoschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// files_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>files:read</c></param>
    /// <param name="user">Filter files created by a single user.</param>
    /// <param name="channel">Filter files appearing in a specific channel, indicated by its ID.</param>
    /// <param name="tsFrom">Filter files created after this timestamp (inclusive).</param>
    /// <param name="tsTo">Filter files created before this timestamp (inclusive).</param>
    /// <param name="types">Filter files by type (<see href="#file_types">see below</see>). You can pass multiple values in the types argument, like <c>types=spaces,snippets</c>.The default value is <c>all</c>, which does not filter the list.</param>
    /// <param name="count"></param>
    /// <param name="page"></param>
    /// <param name="showFilesHiddenByLimit">Show truncated file info for files hidden due to being too old, and the team who owns the file being over the file limit.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FilesListschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List for a team, in a channel, or from a user with applied filters.
    /// </remarks>
    public Task<FilesListschema> FilesList(string? token,
        string? user,
        string? channel,
        double? tsFrom,
        double? tsTo,
        string? types,
        string? count,
        string? page,
        bool? showFilesHiddenByLimit,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/files.list"),
            [],
            [new Param("token", token),
                new Param("user", user),
                new Param("channel", channel),
                new Param("ts_from", tsFrom),
                new Param("ts_to", tsTo),
                new Param("types", types),
                new Param("count", count),
                new Param("page", page),
                new Param("show_files_hidden_by_limit", showFilesHiddenByLimit)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FilesListschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// files_remote_add
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="externalId"></param>
    /// <param name="title"></param>
    /// <param name="filetype"></param>
    /// <param name="externalUrl"></param>
    /// <param name="previewImage"></param>
    /// <param name="indexableFileContents"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds a file from a remote service
    /// </remarks>
    public Task<Defaultsuccesstemplate> FilesRemoteAdd(ContentType contentType,
        string? token,
        string? externalId,
        string? title,
        string? filetype,
        string? externalUrl,
        string? previewImage,
        string? indexableFileContents,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/files.remote.add"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token),
                    new Param("external_id", externalId),
                    new Param("title", title),
                    new Param("filetype", filetype),
                    new Param("external_url", externalUrl),
                    new Param("preview_image", previewImage),
                    new Param("indexable_file_contents", indexableFileContents)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// files_remote_info
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>remote_files:read</c></param>
    /// <param name="file">Specify a file by providing its ID.</param>
    /// <param name="externalId">Creator defined GUID for the file.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve information about a remote file added to Slack
    /// </remarks>
    public Task<Defaultsuccesstemplate> FilesRemoteInfo(string? token,
        string? file,
        string? externalId,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/files.remote.info"),
            [],
            [new Param("token", token), new Param("file", file), new Param("external_id", externalId)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// files_remote_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>remote_files:read</c></param>
    /// <param name="channel">Filter files appearing in a specific channel, indicated by its ID.</param>
    /// <param name="tsFrom">Filter files created after this timestamp (inclusive).</param>
    /// <param name="tsTo">Filter files created before this timestamp (inclusive).</param>
    /// <param name="limit">The maximum number of items to return.</param>
    /// <param name="cursor">Paginate through collections of data by setting the <c>cursor</c> parameter to a <c>next_cursor</c> attribute returned by a previous request's <c>response_metadata</c>. Default value fetches the first "page" of the collection.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve information about a remote file added to Slack
    /// </remarks>
    public Task<Defaultsuccesstemplate> FilesRemoteList(string? token,
        string? channel,
        double? tsFrom,
        double? tsTo,
        int? limit,
        string? cursor,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/files.remote.list"),
            [],
            [new Param("token", token),
                new Param("channel", channel),
                new Param("ts_from", tsFrom),
                new Param("ts_to", tsTo),
                new Param("limit", limit),
                new Param("cursor", cursor)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// files_remote_remove
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="file"></param>
    /// <param name="externalId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Remove a remote file.
    /// </remarks>
    public Task<Defaultsuccesstemplate> FilesRemoteRemove(ContentType contentType,
        string? token,
        string? file,
        string? externalId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/files.remote.remove"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token),
                    new Param("file", file),
                    new Param("external_id", externalId)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// files_remote_share
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>remote_files:share</c></param>
    /// <param name="file">Specify a file registered with Slack by providing its ID. Either this field or <c>external_id</c> or both are required.</param>
    /// <param name="externalId">The globally unique identifier (GUID) for the file, as set by the app registering the file with Slack.  Either this field or <c>file</c> or both are required.</param>
    /// <param name="channels">Comma-separated list of channel IDs where the file will be shared.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Share a remote file into a channel.
    /// </remarks>
    public Task<Defaultsuccesstemplate> FilesRemoteShare(string? token,
        string? file,
        string? externalId,
        string? channels,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/files.remote.share"),
            [],
            [new Param("token", token),
                new Param("file", file),
                new Param("external_id", externalId),
                new Param("channels", channels)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// files_remote_update
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="file"></param>
    /// <param name="externalId"></param>
    /// <param name="title"></param>
    /// <param name="filetype"></param>
    /// <param name="externalUrl"></param>
    /// <param name="previewImage"></param>
    /// <param name="indexableFileContents"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates an existing remote file.
    /// </remarks>
    public Task<Defaultsuccesstemplate> FilesRemoteUpdate(ContentType contentType,
        string? token,
        string? file,
        string? externalId,
        string? title,
        string? filetype,
        string? externalUrl,
        string? previewImage,
        string? indexableFileContents,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/files.remote.update"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token),
                    new Param("file", file),
                    new Param("external_id", externalId),
                    new Param("title", title),
                    new Param("filetype", filetype),
                    new Param("external_url", externalUrl),
                    new Param("preview_image", previewImage),
                    new Param("indexable_file_contents", indexableFileContents)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// files_revokePublicURL
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>files:write:user</c></param>
    /// <param name="file"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FilesRevokePublicUrlschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Revokes public/external sharing access for a file
    /// </remarks>
    public Task<FilesRevokePublicUrlschema> FilesRevokePublicUrl(ContentType contentType,
        string? token,
        string? file,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/files.revokePublicURL"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("file", file)]),
            JsonResponse.Create<FilesRevokePublicUrlschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// files_sharedPublicURL
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>files:write:user</c></param>
    /// <param name="file"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FilesSharedPublicUrlschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enables a file for public/external sharing.
    /// </remarks>
    public Task<FilesSharedPublicUrlschema> FilesSharedPublicUrl(ContentType contentType,
        string? token,
        string? file,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/files.sharedPublicURL"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("file", file)]),
            JsonResponse.Create<FilesSharedPublicUrlschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// files_upload
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="file"></param>
    /// <param name="content"></param>
    /// <param name="filetype"></param>
    /// <param name="filename"></param>
    /// <param name="title"></param>
    /// <param name="initialComment"></param>
    /// <param name="channels"></param>
    /// <param name="threadTs"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FilesUploadschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uploads or creates a file.
    /// </remarks>
    public Task<FilesUploadschema> FilesUpload(ContentType contentType,
        string? token,
        string? file,
        string? content,
        string? filetype,
        string? filename,
        string? title,
        string? initialComment,
        string? channels,
        double? threadTs,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/files.upload"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token),
                    new Param("file", file),
                    new Param("content", content),
                    new Param("filetype", filetype),
                    new Param("filename", filename),
                    new Param("title", title),
                    new Param("initial_comment", initialComment),
                    new Param("channels", channels),
                    new Param("thread_ts", threadTs)]),
            JsonResponse.Create<FilesUploadschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
