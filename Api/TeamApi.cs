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

public sealed class TeamApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TeamApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// team_accessLogs
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin</c></param>
    /// <param name="before">End of time range of logs to include in results (inclusive).</param>
    /// <param name="count"></param>
    /// <param name="page"></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TeamAccessLogsschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Gets the access logs for the current team.
    /// </remarks>
    public Task<TeamAccessLogsschema> TeamAccessLogs(string token,
        string? before,
        string? count,
        string? page,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/team.accessLogs"),
            [],
            [new Param("token", token),
                new Param("before", before),
                new Param("count", count),
                new Param("page", page)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TeamAccessLogsschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// team_billableInfo
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin</c></param>
    /// <param name="user">A user to retrieve the billable information for. Defaults to all users.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Gets billable users information for the current team.
    /// </remarks>
    public Task<Defaultsuccesstemplate> TeamBillableInfo(string token,
        string? user,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/team.billableInfo"),
            [],
            [new Param("token", token), new Param("user", user)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// team_info
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>team:read</c></param>
    /// <param name="team">Team to get info on, if omitted, will return information about the current team. Will only return team that the authenticated token is allowed to see through external shared channels</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TeamInfoschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Gets information about the current team.
    /// </remarks>
    public Task<TeamInfoschema> TeamInfo(string token,
        string? team,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/team.info"),
            [],
            [new Param("token", token), new Param("team", team)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TeamInfoschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// team_integrationLogs
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin</c></param>
    /// <param name="appId">Filter logs to this Slack app. Defaults to all logs.</param>
    /// <param name="changeType">Filter logs with this change type. Defaults to all logs.</param>
    /// <param name="count"></param>
    /// <param name="page"></param>
    /// <param name="serviceId">Filter logs to this service. Defaults to all logs.</param>
    /// <param name="user">Filter logs generated by this user’s actions. Defaults to all logs.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TeamIntegrationLogsschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Gets the integration logs for the current team.
    /// </remarks>
    public Task<TeamIntegrationLogsschema> TeamIntegrationLogs(string token,
        string? appId,
        string? changeType,
        string? count,
        string? page,
        string? serviceId,
        string? user,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/team.integrationLogs"),
            [],
            [new Param("token", token),
                new Param("app_id", appId),
                new Param("change_type", changeType),
                new Param("count", count),
                new Param("page", page),
                new Param("service_id", serviceId),
                new Param("user", user)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TeamIntegrationLogsschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// team_profile_get
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>users.profile:read</c></param>
    /// <param name="visibility">Filter by visibility.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TeamProfileGetsuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve a team's profile.
    /// </remarks>
    public Task<TeamProfileGetsuccessschema> TeamProfileGet(string token,
        string? visibility,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/team.profile.get"),
            [],
            [new Param("token", token), new Param("visibility", visibility)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TeamProfileGetsuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
