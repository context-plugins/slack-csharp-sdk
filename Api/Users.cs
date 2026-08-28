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

public sealed class Users
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Users(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// users_conversations
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>conversations:read</c></param>
    /// <param name="user">Browse conversations by a specific user ID's membership. Non-public channels are restricted to those where the calling user shares membership.</param>
    /// <param name="types">Mix and match channel types by providing a comma-separated list of any combination of <c>public_channel</c>, <c>private_channel</c>, <c>mpim</c>, <c>im</c></param>
    /// <param name="excludeArchived">Set to <c>true</c> to exclude archived channels from the list</param>
    /// <param name="limit">The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the list hasn't been reached. Must be an integer no larger than 1000.</param>
    /// <param name="cursor">Paginate through collections of data by setting the <c>cursor</c> parameter to a <c>next_cursor</c> attribute returned by a previous request's <c>response_metadata</c>. Default value fetches the first "page" of the collection.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsersConversationssuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List conversations the calling user may access.
    /// </remarks>
    public Task<UsersConversationssuccessschema> UsersConversations(string? token,
        string? user,
        string? types,
        bool? excludeArchived,
        int? limit,
        string? cursor,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users.conversations"),
            [],
            [new Param("token", token),
                new Param("user", user),
                new Param("types", types),
                new Param("exclude_archived", excludeArchived),
                new Param("limit", limit),
                new Param("cursor", cursor)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<UsersConversationssuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// users_deletePhoto
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsersDeletePhotoschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete the user profile photo
    /// </remarks>
    public Task<UsersDeletePhotoschema> UsersDeletePhoto(ContentType contentType,
        string token,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users.deletePhoto"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token)]),
            JsonResponse.Create<UsersDeletePhotoschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// users_getPresence
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>users:read</c></param>
    /// <param name="user">User to get presence info on. Defaults to the authed user.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApImethodusersGetPresence"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Gets user presence information.
    /// </remarks>
    public Task<ApImethodusersGetPresence> UsersGetPresence(string token,
        string? user,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users.getPresence"),
            [],
            [new Param("token", token), new Param("user", user)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApImethodusersGetPresence>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// users_identity
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>identity.basic</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get a user's identity.
    /// </remarks>
    public Task<object> UsersIdentity(string? token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users.identity"),
            [],
            [new Param("token", token)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// users_info
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>users:read</c></param>
    /// <param name="includeLocale">Set this to <c>true</c> to receive the locale for this user. Defaults to <c>false</c></param>
    /// <param name="user">User to get info on</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsersInfosuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Gets information about a user.
    /// </remarks>
    public Task<UsersInfosuccessschema> UsersInfo(string token,
        bool? includeLocale,
        string? user,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users.info"),
            [],
            [new Param("token", token), new Param("include_locale", includeLocale), new Param("user", user)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<UsersInfosuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// users_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>users:read</c></param>
    /// <param name="limit">The maximum number of items to return. Fewer than the requested number of items may be returned, even if the end of the users list hasn't been reached. Providing no <c>limit</c> value will result in Slack attempting to deliver you the entire result set. If the collection is too large you may experience <c>limit_required</c> or HTTP 500 errors.</param>
    /// <param name="cursor">Paginate through collections of data by setting the <c>cursor</c> parameter to a <c>next_cursor</c> attribute returned by a previous request's <c>response_metadata</c>. Default value fetches the first "page" of the collection.</param>
    /// <param name="includeLocale">Set this to <c>true</c> to receive the locale for users. Defaults to <c>false</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsersListschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists all users in a Slack team.
    /// </remarks>
    public Task<UsersListschema> UsersList(string? token,
        int? limit,
        string? cursor,
        bool? includeLocale,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users.list"),
            [],
            [new Param("token", token),
                new Param("limit", limit),
                new Param("cursor", cursor),
                new Param("include_locale", includeLocale)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<UsersListschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// users_lookupByEmail
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>users:read.email</c></param>
    /// <param name="email">An email address belonging to a user in the workspace</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsersLookupByEmailsuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Find a user with an email address.
    /// </remarks>
    public Task<UsersLookupByEmailsuccessschema> UsersLookupByEmail(string token,
        string email,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users.lookupByEmail"),
            [],
            [new Param("token", token), new Param("email", email)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<UsersLookupByEmailsuccessschema>(),
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
    /// users_setActive
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsersSetActiveschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Marked a user as active. Deprecated and non-functional.
    /// </remarks>
    public Task<UsersSetActiveschema> UsersSetActive(string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users.setActive"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<UsersSetActiveschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// users_setPhoto
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="cropW"></param>
    /// <param name="cropX"></param>
    /// <param name="cropY"></param>
    /// <param name="image"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsersSetPhotoschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set the user profile photo
    /// </remarks>
    public Task<UsersSetPhotoschema> UsersSetPhoto(ContentType contentType,
        string token,
        string? cropW,
        string? cropX,
        string? cropY,
        string? image,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users.setPhoto"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token),
                    new Param("crop_w", cropW),
                    new Param("crop_x", cropX),
                    new Param("crop_y", cropY),
                    new Param("image", image)]),
            JsonResponse.Create<UsersSetPhotoschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// users_setPresence
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>users:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="presence"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UsersSetPresenceschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Manually sets user presence.
    /// </remarks>
    public Task<UsersSetPresenceschema> UsersSetPresence(string token,
        ContentType contentType,
        string presence,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users.setPresence"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("presence", presence)]),
            JsonResponse.Create<UsersSetPresenceschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
