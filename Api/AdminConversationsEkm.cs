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

public sealed class AdminConversationsEkm
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AdminConversationsEkm(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// admin_conversations_ekm_listOriginalConnectedChannelInfo
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.conversations:read</c></param>
    /// <param name="channelIds">A comma-separated list of channels to filter to.</param>
    /// <param name="teamIds">A comma-separated list of the workspaces to which the channels you would like returned belong.</param>
    /// <param name="limit">The maximum number of items to return. Must be between 1 - 1000 both inclusive.</param>
    /// <param name="cursor">Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all disconnected channels—i.e., channels that were once connected to other workspaces and then disconnected—and the corresponding original channel IDs for key revocation with EKM.
    /// </remarks>
    public Task<Defaultsuccesstemplate> AdminConversationsEkmListOriginalConnectedChannelInfo(string token,
        string? channelIds,
        string? teamIds,
        int? limit,
        string? cursor,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.conversations.ekm.listOriginalConnectedChannelInfo"),
            [],
            [new Param("token", token),
                new Param("channel_ids", channelIds),
                new Param("team_ids", teamIds),
                new Param("limit", limit),
                new Param("cursor", cursor)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// admin_conversations_ekm_listOriginalConnectedChannelInfo
    /// </summary>
    /// <param name="token">Authentication token. Requires scope: <c>admin.conversations:read</c></param>
    /// <param name="channelIds">A comma-separated list of channels to filter to.</param>
    /// <param name="teamIds">A comma-separated list of the workspaces to which the channels you would like returned belong.</param>
    /// <param name="limit">The maximum number of items to return. Must be between 1 - 1000 both inclusive.</param>
    /// <param name="cursor">Set <c>cursor</c> to <c>next_cursor</c> returned by the previous call to list items in the next page.</param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all disconnected channels—i.e., channels that were once connected to other workspaces and then disconnected—and the corresponding original channel IDs for key revocation with EKM.
    /// </remarks>
    public Task<Defaultsuccesstemplate1> AdminConversationsEkmListOriginalConnectedChannelInfo1(string token,
        string? channelIds,
        string? teamIds,
        int? limit,
        string? cursor,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin.conversations.ekm.listOriginalConnectedChannelInfo"),
            [],
            [new Param("token", token),
                new Param("channel_ids", channelIds),
                new Param("team_ids", teamIds),
                new Param("limit", limit),
                new Param("cursor", cursor)],
            [new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate1>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
