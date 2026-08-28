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

public sealed class Migration
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Migration(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// migration_exchange
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>tokens.basic</c></param>
    /// <param name="users">A comma-separated list of user ids, up to 400 per request</param>
    /// <param name="teamId">Specify team_id starts with <c>T</c> in case of Org Token</param>
    /// <param name="toOld">Specify <c>true</c> to convert <c>W</c> global user IDs to workspace-specific <c>U</c> IDs. Defaults to <c>false</c>.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MigrationExchangesuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// For Enterprise Grid workspaces, map local user IDs to global user IDs
    /// </remarks>
    public Task<MigrationExchangesuccessschema> MigrationExchange(string token,
        string users,
        string? teamId,
        bool? toOld,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/migration.exchange"),
            [],
            [new Param("token", token),
                new Param("users", users),
                new Param("team_id", teamId),
                new Param("to_old", toOld)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<MigrationExchangesuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
