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

public sealed class OauthV2
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal OauthV2(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// oauth_v2_access
    /// </summary>
    /// <param name="code">The <c>code</c> param returned via the OAuth callback.</param>
    /// <param name="clientId">Issued when you created your application.</param>
    /// <param name="clientSecret">Issued when you created your application.</param>
    /// <param name="redirectUri">This must match the originally submitted URI (if one was sent).</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Exchanges a temporary OAuth verifier code for an access token.
    /// </remarks>
    public Task<Defaultsuccesstemplate> OauthV2Access(string code,
        string? clientId,
        string? clientSecret,
        string? redirectUri,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/oauth.v2.access"),
            [],
            [new Param("code", code),
                new Param("client_id", clientId),
                new Param("client_secret", clientSecret),
                new Param("redirect_uri", redirectUri)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
