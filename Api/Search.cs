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

public sealed class Search
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Search(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// search_messages
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>search:read</c></param>
    /// <param name="query">Search query.</param>
    /// <param name="count">Pass the number of results you want per "page". Maximum of <c>100</c>.</param>
    /// <param name="highlight">Pass a value of <c>true</c> to enable query highlight markers (see below).</param>
    /// <param name="page"></param>
    /// <param name="sort">Return matches sorted by either <c>score</c> or <c>timestamp</c>.</param>
    /// <param name="sortDir">Change sort direction to ascending (<c>asc</c>) or descending (<c>desc</c>).</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Searches for messages matching a query.
    /// </remarks>
    public Task<Defaultsuccesstemplate> SearchMessages(string token,
        string query,
        int? count,
        bool? highlight,
        int? page,
        string? sort,
        string? sortDir,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/search.messages"),
            [],
            [new Param("token", token),
                new Param("query", query),
                new Param("count", count),
                new Param("highlight", highlight),
                new Param("page", page),
                new Param("sort", sort),
                new Param("sort_dir", sortDir)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// search_messages
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>search:read</c></param>
    /// <param name="query">Search query.</param>
    /// <param name="count">Pass the number of results you want per "page". Maximum of <c>100</c>.</param>
    /// <param name="highlight">Pass a value of <c>true</c> to enable query highlight markers (see below).</param>
    /// <param name="page"></param>
    /// <param name="sort">Return matches sorted by either <c>score</c> or <c>timestamp</c>.</param>
    /// <param name="sortDir">Change sort direction to ascending (<c>asc</c>) or descending (<c>desc</c>).</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Searches for messages matching a query.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> SearchMessages1(string token,
        string query,
        int? count,
        bool? highlight,
        int? page,
        string? sort,
        string? sortDir,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/search.messages"),
            [],
            [new Param("token", token),
                new Param("query", query),
                new Param("count", count),
                new Param("highlight", highlight),
                new Param("page", page),
                new Param("sort", sort),
                new Param("sort_dir", sortDir)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
