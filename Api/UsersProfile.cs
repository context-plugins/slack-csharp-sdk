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

public sealed class UsersProfile
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal UsersProfile(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// users_profile_get
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>users.profile:read</c></param>
    /// <param name="includeLabels">Include labels for each ID in custom profile fields</param>
    /// <param name="user">User to retrieve profile info for</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsersProfileGetschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a user's profile information.
    /// </remarks>
    public Task<UsersProfileGetschema> UsersProfileGet(string token,
        bool? includeLabels,
        string? user,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users.profile.get"),
            [],
            [new Param("token", token), new Param("include_labels", includeLabels), new Param("user", user)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<UsersProfileGetschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// users_profile_get
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>users.profile:read</c></param>
    /// <param name="includeLabels">Include labels for each ID in custom profile fields</param>
    /// <param name="user">User to retrieve profile info for</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsersProfileGetschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a user's profile information.
    /// </remarks>
    public Task<UsersProfileGetschema1> UsersProfileGet1(string token,
        bool? includeLabels,
        string? user,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users.profile.get"),
            [],
            [new Param("token", token), new Param("include_labels", includeLabels), new Param("user", user)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<UsersProfileGetschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// users_profile_set
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>users.profile:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="name"></param>
    /// <param name="profile"></param>
    /// <param name="user"></param>
    /// <param name="value"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsersProfileSetschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set the profile information for a user.
    /// </remarks>
    public Task<UsersProfileSetschema> UsersProfileSet(string token,
        ContentType contentType,
        string? name,
        string? profile,
        string? user,
        string? value,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users.profile.set"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("name", name),
                    new Param("profile", profile),
                    new Param("user", user),
                    new Param("value", value)]),
            JsonResponse.Create<UsersProfileSetschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// users_profile_set
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>users.profile:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="name"></param>
    /// <param name="profile"></param>
    /// <param name="user"></param>
    /// <param name="value"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsersProfileSetschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set the profile information for a user.
    /// </remarks>
    public Task<UsersProfileSetschema1> UsersProfileSet1(string token,
        ContentType contentType,
        string? name,
        string? profile,
        string? user,
        string? value,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users.profile.set"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("name", name),
                    new Param("profile", profile),
                    new Param("user", user),
                    new Param("value", value)]),
            JsonResponse.Create<UsersProfileSetschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
