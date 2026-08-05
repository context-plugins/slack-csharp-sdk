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

public sealed class Usergroups
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Usergroups(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// usergroups_create
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>usergroups:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="name"></param>
    /// <param name="channels"></param>
    /// <param name="description"></param>
    /// <param name="handle"></param>
    /// <param name="includeCount"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsergroupsCreateschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a User Group
    /// </remarks>
    public Task<UsergroupsCreateschema> UsergroupsCreate(string token,
        ContentType contentType,
        string name,
        string? channels,
        string? description,
        string? handle,
        bool? includeCount,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/usergroups.create"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("name", name),
                    new Param("channels", channels),
                    new Param("description", description),
                    new Param("handle", handle),
                    new Param("include_count", includeCount)]),
            JsonResponse.Create<UsergroupsCreateschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// usergroups_create
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>usergroups:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="name"></param>
    /// <param name="channels"></param>
    /// <param name="description"></param>
    /// <param name="handle"></param>
    /// <param name="includeCount"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsergroupsCreateschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a User Group
    /// </remarks>
    public Task<UsergroupsCreateschema1> UsergroupsCreate1(string token,
        ContentType contentType,
        string name,
        string? channels,
        string? description,
        string? handle,
        bool? includeCount,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/usergroups.create"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("name", name),
                    new Param("channels", channels),
                    new Param("description", description),
                    new Param("handle", handle),
                    new Param("include_count", includeCount)]),
            JsonResponse.Create<UsergroupsCreateschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// usergroups_disable
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>usergroups:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="usergroup"></param>
    /// <param name="includeCount"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsergroupsDisableschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Disable an existing User Group
    /// </remarks>
    public Task<UsergroupsDisableschema> UsergroupsDisable(string token,
        ContentType contentType,
        string usergroup,
        bool? includeCount,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/usergroups.disable"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("usergroup", usergroup),
                    new Param("include_count", includeCount)]),
            JsonResponse.Create<UsergroupsDisableschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// usergroups_disable
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>usergroups:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="usergroup"></param>
    /// <param name="includeCount"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsergroupsDisableschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Disable an existing User Group
    /// </remarks>
    public Task<UsergroupsDisableschema1> UsergroupsDisable1(string token,
        ContentType contentType,
        string usergroup,
        bool? includeCount,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/usergroups.disable"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("usergroup", usergroup),
                    new Param("include_count", includeCount)]),
            JsonResponse.Create<UsergroupsDisableschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// usergroups_enable
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>usergroups:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="usergroup"></param>
    /// <param name="includeCount"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsergroupsEnableschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enable a User Group
    /// </remarks>
    public Task<UsergroupsEnableschema> UsergroupsEnable(string token,
        ContentType contentType,
        string usergroup,
        bool? includeCount,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/usergroups.enable"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("usergroup", usergroup),
                    new Param("include_count", includeCount)]),
            JsonResponse.Create<UsergroupsEnableschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// usergroups_enable
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>usergroups:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="usergroup"></param>
    /// <param name="includeCount"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsergroupsEnableschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enable a User Group
    /// </remarks>
    public Task<UsergroupsEnableschema1> UsergroupsEnable1(string token,
        ContentType contentType,
        string usergroup,
        bool? includeCount,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/usergroups.enable"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("usergroup", usergroup),
                    new Param("include_count", includeCount)]),
            JsonResponse.Create<UsergroupsEnableschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// usergroups_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>usergroups:read</c></param>
    /// <param name="includeUsers">Include the list of users for each User Group.</param>
    /// <param name="includeCount">Include the number of users in each User Group.</param>
    /// <param name="includeDisabled">Include disabled User Groups.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsergroupsListschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all User Groups for a team
    /// </remarks>
    public Task<UsergroupsListschema> UsergroupsList(string token,
        bool? includeUsers,
        bool? includeCount,
        bool? includeDisabled,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/usergroups.list"),
            [],
            [new Param("token", token),
                new Param("include_users", includeUsers),
                new Param("include_count", includeCount),
                new Param("include_disabled", includeDisabled)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<UsergroupsListschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// usergroups_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>usergroups:read</c></param>
    /// <param name="includeUsers">Include the list of users for each User Group.</param>
    /// <param name="includeCount">Include the number of users in each User Group.</param>
    /// <param name="includeDisabled">Include disabled User Groups.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsergroupsListschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all User Groups for a team
    /// </remarks>
    public Task<UsergroupsListschema1> UsergroupsList1(string token,
        bool? includeUsers,
        bool? includeCount,
        bool? includeDisabled,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/usergroups.list"),
            [],
            [new Param("token", token),
                new Param("include_users", includeUsers),
                new Param("include_count", includeCount),
                new Param("include_disabled", includeDisabled)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<UsergroupsListschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// usergroups_update
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>usergroups:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="usergroup"></param>
    /// <param name="handle"></param>
    /// <param name="description"></param>
    /// <param name="channels"></param>
    /// <param name="includeCount"></param>
    /// <param name="name"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsergroupsUpdateschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an existing User Group
    /// </remarks>
    public Task<UsergroupsUpdateschema> UsergroupsUpdate(string token,
        ContentType contentType,
        string usergroup,
        string? handle,
        string? description,
        string? channels,
        bool? includeCount,
        string? name,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/usergroups.update"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("usergroup", usergroup),
                    new Param("handle", handle),
                    new Param("description", description),
                    new Param("channels", channels),
                    new Param("include_count", includeCount),
                    new Param("name", name)]),
            JsonResponse.Create<UsergroupsUpdateschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// usergroups_update
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>usergroups:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="usergroup"></param>
    /// <param name="handle"></param>
    /// <param name="description"></param>
    /// <param name="channels"></param>
    /// <param name="includeCount"></param>
    /// <param name="name"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsergroupsUpdateschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an existing User Group
    /// </remarks>
    public Task<UsergroupsUpdateschema1> UsergroupsUpdate1(string token,
        ContentType contentType,
        string usergroup,
        string? handle,
        string? description,
        string? channels,
        bool? includeCount,
        string? name,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/usergroups.update"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("usergroup", usergroup),
                    new Param("handle", handle),
                    new Param("description", description),
                    new Param("channels", channels),
                    new Param("include_count", includeCount),
                    new Param("name", name)]),
            JsonResponse.Create<UsergroupsUpdateschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// usergroups_users_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>usergroups:read</c></param>
    /// <param name="usergroup">The encoded ID of the User Group to update.</param>
    /// <param name="includeDisabled">Allow results that involve disabled User Groups.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsergroupsUsersListschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all users in a User Group
    /// </remarks>
    public Task<UsergroupsUsersListschema> UsergroupsUsersList(string token,
        string usergroup,
        bool? includeDisabled,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/usergroups.users.list"),
            [],
            [new Param("token", token),
                new Param("usergroup", usergroup),
                new Param("include_disabled", includeDisabled)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<UsergroupsUsersListschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// usergroups_users_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>usergroups:read</c></param>
    /// <param name="usergroup">The encoded ID of the User Group to update.</param>
    /// <param name="includeDisabled">Allow results that involve disabled User Groups.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsergroupsUsersListschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all users in a User Group
    /// </remarks>
    public Task<UsergroupsUsersListschema1> UsergroupsUsersList1(string token,
        string usergroup,
        bool? includeDisabled,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/usergroups.users.list"),
            [],
            [new Param("token", token),
                new Param("usergroup", usergroup),
                new Param("include_disabled", includeDisabled)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<UsergroupsUsersListschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// usergroups_users_update
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>usergroups:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="usergroup"></param>
    /// <param name="users"></param>
    /// <param name="includeCount"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsergroupsUsersUpdateschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update the list of users for a User Group
    /// </remarks>
    public Task<UsergroupsUsersUpdateschema> UsergroupsUsersUpdate(string token,
        ContentType contentType,
        string usergroup,
        string users,
        bool? includeCount,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/usergroups.users.update"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("usergroup", usergroup),
                    new Param("users", users),
                    new Param("include_count", includeCount)]),
            JsonResponse.Create<UsergroupsUsersUpdateschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// usergroups_users_update
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>usergroups:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="usergroup"></param>
    /// <param name="users"></param>
    /// <param name="includeCount"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsergroupsUsersUpdateschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update the list of users for a User Group
    /// </remarks>
    public Task<UsergroupsUsersUpdateschema1> UsergroupsUsersUpdate1(string token,
        ContentType contentType,
        string usergroup,
        string users,
        bool? includeCount,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/usergroups.users.update"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("usergroup", usergroup),
                    new Param("users", users),
                    new Param("include_count", includeCount)]),
            JsonResponse.Create<UsergroupsUsersUpdateschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
