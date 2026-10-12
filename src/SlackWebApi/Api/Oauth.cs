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
using SlackWebApi.Requests.Oauth;
using SlackWebApi.Requests.OauthV2;

namespace SlackWebApi.Api;

public sealed class Oauth
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Oauth(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// oauth_access
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Exchanges a temporary OAuth verifier code for an access token.
    /// </remarks>
    public Task<Defaultsuccesstemplate> OauthAccess(OauthAccessRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/oauth.access"),
            [],
            [
                new Param("client_id", request.ClientId),
                new Param("client_secret", request.ClientSecret),
                new Param("code", request.Code),
                new Param("redirect_uri", request.RedirectUri),
                new Param("single_channel", request.SingleChannel),
            ],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// oauth_token
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Exchanges a temporary OAuth verifier code for a workspace token.
    /// </remarks>
    public Task<Defaultsuccesstemplate> OauthToken(OauthTokenRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/oauth.token"),
            [],
            [
                new Param("client_id", request.ClientId),
                new Param("client_secret", request.ClientSecret),
                new Param("code", request.Code),
                new Param("redirect_uri", request.RedirectUri),
                new Param("single_channel", request.SingleChannel),
            ],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// oauth_v2_access
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Exchanges a temporary OAuth verifier code for an access token.
    /// </remarks>
    public Task<Defaultsuccesstemplate> OauthV2Access(OauthV2AccessRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/oauth.v2.access"),
            [],
            [
                new Param("code", request.Code),
                new Param("client_id", request.ClientId),
                new Param("client_secret", request.ClientSecret),
                new Param("redirect_uri", request.RedirectUri),
            ],
            [new HeaderParam("Content-Type", request.ContentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            cancellationToken);
}
