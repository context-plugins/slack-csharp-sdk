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

public sealed class Reminders
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Reminders(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// reminders_add
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>reminders:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="text"></param>
    /// <param name="time"></param>
    /// <param name="user"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RemindersAddschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a reminder.
    /// </remarks>
    public Task<RemindersAddschema> RemindersAdd(string token,
        ContentType contentType,
        string text,
        string time,
        string? user,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reminders.add"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("text", text),
                    new Param("time", time),
                    new Param("user", user)]),
            JsonResponse.Create<RemindersAddschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// reminders_add
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>reminders:write</c></param>
    /// <param name="contentType"></param>
    /// <param name="text"></param>
    /// <param name="time"></param>
    /// <param name="user"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RemindersAddschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a reminder.
    /// </remarks>
    public Task<RemindersAddschema1> RemindersAdd1(string token,
        ContentType contentType,
        string text,
        string time,
        string? user,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reminders.add"),
            [],
            [],
            [new HeaderParam("token", token),
                new HeaderParam("Content-Type", contentType),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("text", text),
                    new Param("time", time),
                    new Param("user", user)]),
            JsonResponse.Create<RemindersAddschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// reminders_complete
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>reminders:write</c></param>
    /// <param name="reminder"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RemindersCompleteschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Marks a reminder as complete.
    /// </remarks>
    public Task<RemindersCompleteschema> RemindersComplete(ContentType contentType,
        string? token,
        string? reminder,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reminders.complete"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("reminder", reminder)]),
            JsonResponse.Create<RemindersCompleteschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// reminders_complete
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>reminders:write</c></param>
    /// <param name="reminder"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RemindersCompleteschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Marks a reminder as complete.
    /// </remarks>
    public Task<RemindersCompleteschema1> RemindersComplete1(ContentType contentType,
        string? token,
        string? reminder,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reminders.complete"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("reminder", reminder)]),
            JsonResponse.Create<RemindersCompleteschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// reminders_delete
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>reminders:write</c></param>
    /// <param name="reminder"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RemindersDeleteschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a reminder.
    /// </remarks>
    public Task<RemindersDeleteschema> RemindersDelete(ContentType contentType,
        string? token,
        string? reminder,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reminders.delete"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("reminder", reminder)]),
            JsonResponse.Create<RemindersDeleteschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// reminders_delete
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="token">Authentication token. Requires scope: <c>reminders:write</c></param>
    /// <param name="reminder"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RemindersDeleteschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a reminder.
    /// </remarks>
    public Task<RemindersDeleteschema1> RemindersDelete1(ContentType contentType,
        string? token,
        string? reminder,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reminders.delete"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("token", token),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create([new Param("reminder", reminder)]),
            JsonResponse.Create<RemindersDeleteschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// reminders_info
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>reminders:read</c></param>
    /// <param name="reminder">The ID of the reminder</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RemindersInfoschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Gets information about a reminder.
    /// </remarks>
    public Task<RemindersInfoschema> RemindersInfo(string? token,
        string? reminder,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reminders.info"),
            [],
            [new Param("token", token), new Param("reminder", reminder)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RemindersInfoschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// reminders_info
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>reminders:read</c></param>
    /// <param name="reminder">The ID of the reminder</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RemindersInfoschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Gets information about a reminder.
    /// </remarks>
    public Task<RemindersInfoschema1> RemindersInfo1(string? token,
        string? reminder,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reminders.info"),
            [],
            [new Param("token", token), new Param("reminder", reminder)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RemindersInfoschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// reminders_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>reminders:read</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RemindersListschema"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists all reminders created by or for a given user.
    /// </remarks>
    public Task<RemindersListschema> RemindersList(string? token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reminders.list"),
            [],
            [new Param("token", token)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RemindersListschema>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// reminders_list
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>reminders:read</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RemindersListschema1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists all reminders created by or for a given user.
    /// </remarks>
    public Task<RemindersListschema1> RemindersList1(string? token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reminders.list"),
            [],
            [new Param("token", token)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RemindersListschema1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
