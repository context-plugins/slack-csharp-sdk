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

public sealed class AdminTeams
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AdminTeams(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// admin_teams_create
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.teams:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamDomain"></param>
    /// <param name="teamName"></param>
    /// <param name="teamDescription"></param>
    /// <param name="teamDiscoverability"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an Enterprise team.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsCreate(string token,
        ContentType contentType,
        string teamDomain,
        string teamName,
        string? teamDescription,
        string? teamDiscoverability,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.teams.create"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_domain", teamDomain),
                    new Param("team_name", teamName),
                    new Param("team_description", teamDescription),
                    new Param("team_discoverability", teamDiscoverability)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_teams_create
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.teams:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamDomain"></param>
    /// <param name="teamName"></param>
    /// <param name="teamDescription"></param>
    /// <param name="teamDiscoverability"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an Enterprise team.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AdminTeamsCreate1(string token,
        ContentType contentType,
        string teamDomain,
        string teamName,
        string? teamDescription,
        string? teamDiscoverability,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.teams.create"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_domain", teamDomain),
                    new Param("team_name", teamName),
                    new Param("team_description", teamDescription),
                    new Param("team_discoverability", teamDiscoverability)]),
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_teams_list
    /// </summary>
    /// <param name="limit">The maximum number of items to return. Must be between 1 - 100 both inclusive.</param>
    /// <param name="cursor">Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page.</param>
    /// <param name="token">Authentication token. Requires scope: <c>admin.teams:read</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all teams on an Enterprise organization
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsList(int? limit,
        string? cursor,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.teams.list"),
            [],
            [new Param("limit", limit), new Param("cursor", cursor)],
            [new HeaderParam("token", token), new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_teams_list
    /// </summary>
    /// <param name="limit">The maximum number of items to return. Must be between 1 - 100 both inclusive.</param>
    /// <param name="cursor">Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page.</param>
    /// <param name="token">Authentication token. Requires scope: <c>admin.teams:read</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all teams on an Enterprise organization
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AdminTeamsList1(int? limit,
        string? cursor,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.teams.list"),
            [],
            [new Param("limit", limit), new Param("cursor", cursor)],
            [new HeaderParam("token", token), new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
