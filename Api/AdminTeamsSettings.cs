using System;
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

public sealed class AdminTeamsSettings
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AdminTeamsSettings(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// admin_teams_settings_info
    /// </summary>
    /// <param name="teamId"></param>
    /// <param name="token">Authentication token. Requires scope: <c>admin.teams:read</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch information about settings in a workspace
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsSettingsInfo(string teamId,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.teams.settings.info"),
            [],
            [new Param("team_id", teamId)],
            [new HeaderParam("token", token), new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_teams_settings_setDefaultChannels
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="teamId"></param>
    /// <param name="channelIds"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set the default channels of a workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsSettingsSetDefaultChannels(ContentType contentType,
        string token,
        string teamId,
        string channelIds,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.teams.settings.setDefaultChannels"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token),
                    new Param("team_id", teamId),
                    new Param("channel_ids", channelIds)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_teams_settings_setDescription
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.teams:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="description"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set the description of a given workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsSettingsSetDescription(string token,
        ContentType contentType,
        string teamId,
        string description,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.teams.settings.setDescription"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId), new Param("description", description)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_teams_settings_setDiscoverability
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.teams:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="discoverability"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// An API method that allows admins to set the discoverability of a given workspace
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsSettingsSetDiscoverability(string token,
        ContentType contentType,
        string teamId,
        string discoverability,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.teams.settings.setDiscoverability"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId),
                    new Param("discoverability", discoverability)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_teams_settings_setIcon
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token"></param>
    /// <param name="imageUrl"></param>
    /// <param name="teamId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sets the icon of a workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsSettingsSetIcon(ContentType contentType,
        string token,
        string imageUrl,
        string teamId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.teams.settings.setIcon"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("token", token),
                    new Param("image_url", imageUrl),
                    new Param("team_id", teamId)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_teams_settings_setName
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.teams:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="teamId"></param>
    /// <param name="name"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Set the name of a given workspace.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminTeamsSettingsSetName(string token,
        ContentType contentType,
        string teamId,
        string name,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.teams.settings.setName"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("team_id", teamId), new Param("name", name)]),
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
