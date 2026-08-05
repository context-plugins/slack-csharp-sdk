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

public sealed class AdminAppsApproved
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AdminAppsApproved(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// admin_apps_approved_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.apps:read</c></param>
    /// <param name="limit">The maximum number of items to return. Must be between 1 - 1000 both inclusive.</param>
    /// <param name="cursor">Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page</param>
    /// <param name="teamId"></param>
    /// <param name="enterpriseId"></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List approved apps for an org or workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminAppsApprovedList(string token,
        int? limit,
        string? cursor,
        string? teamId,
        string? enterpriseId,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.apps.approved.list"),
            [],
            [new Param("token", token),
                new Param("limit", limit),
                new Param("cursor", cursor),
                new Param("team_id", teamId),
                new Param("enterprise_id", enterpriseId)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_apps_approved_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.apps:read</c></param>
    /// <param name="limit">The maximum number of items to return. Must be between 1 - 1000 both inclusive.</param>
    /// <param name="cursor">Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page</param>
    /// <param name="teamId"></param>
    /// <param name="enterpriseId"></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List approved apps for an org or workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AdminAppsApprovedList1(string token,
        int? limit,
        string? cursor,
        string? teamId,
        string? enterpriseId,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.apps.approved.list"),
            [],
            [new Param("token", token),
                new Param("limit", limit),
                new Param("cursor", cursor),
                new Param("team_id", teamId),
                new Param("enterprise_id", enterpriseId)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
