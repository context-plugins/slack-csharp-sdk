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
    /// <param name="clientId">Issued when you created your application.</param>
    /// <param name="clientSecret">Issued when you created your application.</param>
    /// <param name="code">The <c>code</c> param returned via the OAuth callback.</param>
    /// <param name="redirectUri">This must match the originally submitted URI (if one was sent).</param>
    /// <param name="singleChannel">Request the user to add your app only to a single channel. Only valid with a <see href="https://api.slack.com/legacy-workspace-apps">legacy workspace app</see>.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Exchanges a temporary OAuth verifier code for an access token.
    /// </remarks>
    public Task<Defaultsuccesstemplate> OauthAccess(string? clientId,
        string? clientSecret,
        string? code,
        string? redirectUri,
        bool? singleChannel,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/oauth.access"),
            [],
            [new Param("client_id", clientId),
                new Param("client_secret", clientSecret),
                new Param("code", code),
                new Param("redirect_uri", redirectUri),
                new Param("single_channel", singleChannel)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// oauth_access
    /// </summary>
    /// <param name="clientId">Issued when you created your application.</param>
    /// <param name="clientSecret">Issued when you created your application.</param>
    /// <param name="code">The <c>code</c> param returned via the OAuth callback.</param>
    /// <param name="redirectUri">This must match the originally submitted URI (if one was sent).</param>
    /// <param name="singleChannel">Request the user to add your app only to a single channel. Only valid with a <see href="https://api.slack.com/legacy-workspace-apps">legacy workspace app</see>.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Exchanges a temporary OAuth verifier code for an access token.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> OauthAccess1(string? clientId,
        string? clientSecret,
        string? code,
        string? redirectUri,
        bool? singleChannel,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/oauth.access"),
            [],
            [new Param("client_id", clientId),
                new Param("client_secret", clientSecret),
                new Param("code", code),
                new Param("redirect_uri", redirectUri),
                new Param("single_channel", singleChannel)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// oauth_token
    /// </summary>
    /// <param name="clientId">Issued when you created your application.</param>
    /// <param name="clientSecret">Issued when you created your application.</param>
    /// <param name="code">The <c>code</c> param returned via the OAuth callback.</param>
    /// <param name="redirectUri">This must match the originally submitted URI (if one was sent).</param>
    /// <param name="singleChannel">Request the user to add your app only to a single channel.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Exchanges a temporary OAuth verifier code for a workspace token.
    /// </remarks>
    public Task<Defaultsuccesstemplate> OauthToken(string? clientId,
        string? clientSecret,
        string? code,
        string? redirectUri,
        bool? singleChannel,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/oauth.token"),
            [],
            [new Param("client_id", clientId),
                new Param("client_secret", clientSecret),
                new Param("code", code),
                new Param("redirect_uri", redirectUri),
                new Param("single_channel", singleChannel)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// oauth_token
    /// </summary>
    /// <param name="clientId">Issued when you created your application.</param>
    /// <param name="clientSecret">Issued when you created your application.</param>
    /// <param name="code">The <c>code</c> param returned via the OAuth callback.</param>
    /// <param name="redirectUri">This must match the originally submitted URI (if one was sent).</param>
    /// <param name="singleChannel">Request the user to add your app only to a single channel.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Exchanges a temporary OAuth verifier code for a workspace token.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> OauthToken1(string? clientId,
        string? clientSecret,
        string? code,
        string? redirectUri,
        bool? singleChannel,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/oauth.token"),
            [],
            [new Param("client_id", clientId),
                new Param("client_secret", clientSecret),
                new Param("code", code),
                new Param("redirect_uri", redirectUri),
                new Param("single_channel", singleChannel)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

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
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Exchanges a temporary OAuth verifier code for an access token.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> OauthV2Access1(string code,
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
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
