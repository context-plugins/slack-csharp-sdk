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

public sealed class ApiApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ApiApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// api_test
    /// </summary>
    /// <param name="error">Error response to return</param>
    /// <param name="foo">example property to return</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiTestsuccessschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Checks API calling code.
    /// </remarks>
    public Task<ApiTestsuccessschema> ApiTest(string? error,
        string? foo,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api.test"),
            [],
            [new Param("error", error), new Param("foo", foo)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiTestsuccessschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// api_test
    /// </summary>
    /// <param name="error">Error response to return</param>
    /// <param name="foo">example property to return</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiTestsuccessschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Checks API calling code.
    /// </remarks>
    public Task<ApiTestsuccessschema1> ApiTest1(string? error,
        string? foo,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api.test"),
            [],
            [new Param("error", error), new Param("foo", foo)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiTestsuccessschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
