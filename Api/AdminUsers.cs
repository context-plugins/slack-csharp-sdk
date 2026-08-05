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

public sealed class AdminUsers
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AdminUsers(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// admin_users_assign
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="userId"></param>
    /// <param name="isRestricted"></param>
    /// <param name="isUltraRestricted"></param>
    /// <param name="channelIds"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Add an Enterprise user to a workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersAssign(string token,
        ContentType contentType,
        string teamId,
        string userId,
        bool? isRestricted,
        bool? isUltraRestricted,
        string? channelIds,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.assign"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId),
                    new Param("user_id", userId),
                    new Param("is_restricted", isRestricted),
                    new Param("is_ultra_restricted", isUltraRestricted),
                    new Param("channel_ids", channelIds)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_assign
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="userId"></param>
    /// <param name="isRestricted"></param>
    /// <param name="isUltraRestricted"></param>
    /// <param name="channelIds"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Add an Enterprise user to a workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AdminUsersAssign1(string token,
        ContentType contentType,
        string teamId,
        string userId,
        bool? isRestricted,
        bool? isUltraRestricted,
        string? channelIds,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.assign"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId),
                    new Param("user_id", userId),
                    new Param("is_restricted", isRestricted),
                    new Param("is_ultra_restricted", isUltraRestricted),
                    new Param("channel_ids", channelIds)]),
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_invite
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="email"></param>
    /// <param name="channelIds"></param>
    /// <param name="customMessage"></param>
    /// <param name="realName"></param>
    /// <param name="resend"></param>
    /// <param name="isRestricted"></param>
    /// <param name="isUltraRestricted"></param>
    /// <param name="guestExpirationTs"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Invite a user to a workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersInvite(string token,
        ContentType contentType,
        string teamId,
        string email,
        string channelIds,
        string? customMessage,
        string? realName,
        bool? resend,
        bool? isRestricted,
        bool? isUltraRestricted,
        string? guestExpirationTs,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.invite"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId),
                    new Param("email", email),
                    new Param("channel_ids", channelIds),
                    new Param("custom_message", customMessage),
                    new Param("real_name", realName),
                    new Param("resend", resend),
                    new Param("is_restricted", isRestricted),
                    new Param("is_ultra_restricted", isUltraRestricted),
                    new Param("guest_expiration_ts", guestExpirationTs)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_invite
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="email"></param>
    /// <param name="channelIds"></param>
    /// <param name="customMessage"></param>
    /// <param name="realName"></param>
    /// <param name="resend"></param>
    /// <param name="isRestricted"></param>
    /// <param name="isUltraRestricted"></param>
    /// <param name="guestExpirationTs"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Invite a user to a workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AdminUsersInvite1(string token,
        ContentType contentType,
        string teamId,
        string email,
        string channelIds,
        string? customMessage,
        string? realName,
        bool? resend,
        bool? isRestricted,
        bool? isUltraRestricted,
        string? guestExpirationTs,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.invite"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId),
                    new Param("email", email),
                    new Param("channel_ids", channelIds),
                    new Param("custom_message", customMessage),
                    new Param("real_name", realName),
                    new Param("resend", resend),
                    new Param("is_restricted", isRestricted),
                    new Param("is_ultra_restricted", isUltraRestricted),
                    new Param("guest_expiration_ts", guestExpirationTs)]),
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_list
    /// </summary>
    /// <param name="teamId">The ID (<c>T1234</c>) of the workspace.</param>
    /// <param name="cursor">Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page.</param>
    /// <param name="limit">Limit for how many users to be retrieved per page</param>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:read</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List users on a workspace
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersList(string teamId,
        string? cursor,
        int? limit,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.list"),
            [],
            [new Param("team_id", teamId), new Param("cursor", cursor), new Param("limit", limit)],
            [new HeaderParam("token", token), new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_list
    /// </summary>
    /// <param name="teamId">The ID (<c>T1234</c>) of the workspace.</param>
    /// <param name="cursor">Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page.</param>
    /// <param name="limit">Limit for how many users to be retrieved per page</param>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:read</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List users on a workspace
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AdminUsersList1(string teamId,
        string? cursor,
        int? limit,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.list"),
            [],
            [new Param("team_id", teamId), new Param("cursor", cursor), new Param("limit", limit)],
            [new HeaderParam("token", token), new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_remove
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="userId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Remove a user from a workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersRemove(string token,
        ContentType contentType,
        string teamId,
        string userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.remove"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId), new Param("user_id", userId)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_remove
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="userId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Remove a user from a workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AdminUsersRemove1(string token,
        ContentType contentType,
        string teamId,
        string userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.remove"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId), new Param("user_id", userId)]),
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_setAdmin
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="userId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set an existing guest, regular user, or owner to be an admin user.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersSetAdmin(string token,
        ContentType contentType,
        string teamId,
        string userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.setAdmin"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId), new Param("user_id", userId)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_setAdmin
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="userId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set an existing guest, regular user, or owner to be an admin user.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AdminUsersSetAdmin1(string token,
        ContentType contentType,
        string teamId,
        string userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.setAdmin"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId), new Param("user_id", userId)]),
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_setExpiration
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="userId"></param>
    /// <param name="expirationTs"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set an expiration for a guest user
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersSetExpiration(string token,
        ContentType contentType,
        string teamId,
        string userId,
        int expirationTs,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.setExpiration"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId),
                    new Param("user_id", userId),
                    new Param("expiration_ts", expirationTs)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_setExpiration
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="userId"></param>
    /// <param name="expirationTs"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set an expiration for a guest user
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AdminUsersSetExpiration1(string token,
        ContentType contentType,
        string teamId,
        string userId,
        int expirationTs,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.setExpiration"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId),
                    new Param("user_id", userId),
                    new Param("expiration_ts", expirationTs)]),
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_setOwner
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="userId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set an existing guest, regular user, or admin user to be a workspace owner.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersSetOwner(string token,
        ContentType contentType,
        string teamId,
        string userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.setOwner"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId), new Param("user_id", userId)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_setOwner
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="userId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set an existing guest, regular user, or admin user to be a workspace owner.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AdminUsersSetOwner1(string token,
        ContentType contentType,
        string teamId,
        string userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.setOwner"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId), new Param("user_id", userId)]),
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_setRegular
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="userId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set an existing guest user, admin user, or owner to be a regular user.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminUsersSetRegular(string token,
        ContentType contentType,
        string teamId,
        string userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.setRegular"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId), new Param("user_id", userId)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_users_setRegular
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="userId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set an existing guest user, admin user, or owner to be a regular user.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AdminUsersSetRegular1(string token,
        ContentType contentType,
        string teamId,
        string userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.users.setRegular"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId), new Param("user_id", userId)]),
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
