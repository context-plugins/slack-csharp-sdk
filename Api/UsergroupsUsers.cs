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

public sealed class UsergroupsUsers
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal UsergroupsUsers(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

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
}
