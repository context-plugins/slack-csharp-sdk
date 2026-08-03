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

public sealed class Workflows
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Workflows(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// workflows_stepCompleted
    /// </summary>
    /// <param name="workflowStepExecuteId">Context identifier that maps to the correct workflow step execution.</param>
    /// <param name="outputs">Key-value object of outputs from your step. Keys of this object reflect the configured <c>key</c> properties of your <see href="/reference/workflows/workflow_step#output"><c>outputs</c></see> array from your <c>workflow_step</c> object.</param>
    /// <param name="token">Authentication token. Requires scope: <c>workflow.steps:execute</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Indicate that an app's step in a workflow completed execution.
    /// </remarks>
    public Task<Defaultsuccesstemplate> WorkflowsStepCompleted(string workflowStepExecuteId,
        string? outputs,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/workflows.stepCompleted"),
            [],
            [new Param("workflow_step_execute_id", workflowStepExecuteId), new Param("outputs", outputs)],
            [new HeaderParam("token", token), new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// workflows_stepFailed
    /// </summary>
    /// <param name="workflowStepExecuteId">Context identifier that maps to the correct workflow step execution.</param>
    /// <param name="error">A JSON-based object with a <c>message</c> property that should contain a human readable error message.</param>
    /// <param name="token">Authentication token. Requires scope: <c>workflow.steps:execute</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Indicate that an app's step in a workflow failed to execute.
    /// </remarks>
    public Task<Defaultsuccesstemplate> WorkflowsStepFailed(string workflowStepExecuteId,
        string error,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/workflows.stepFailed"),
            [],
            [new Param("workflow_step_execute_id", workflowStepExecuteId), new Param("error", error)],
            [new HeaderParam("token", token), new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);

    /// <summary>
    /// workflows_updateStep
    /// </summary>
    /// <param name="workflowStepEditId">A context identifier provided with <c>view_submission</c> payloads used to call back to <c>workflows.updateStep</c>.</param>
    /// <param name="inputs">A JSON key-value map of inputs required from a user during configuration. This is the data your app expects to receive when the workflow step starts. <b>Please note</b>: the embedded variable format is set and replaced by the workflow system. You cannot create custom variables that will be replaced at runtime. <see href="/workflows/steps#variables">Read more about variables in workflow steps here</see>.</param>
    /// <param name="outputs">An JSON array of output objects used during step execution. This is the data your app agrees to provide when your workflow step was executed.</param>
    /// <param name="stepName">An optional field that can be used to override the step name that is shown in the Workflow Builder.</param>
    /// <param name="stepImageUrl">An optional field that can be used to override app image that is shown in the Workflow Builder.</param>
    /// <param name="token">Authentication token. Requires scope: <c>workflow.steps:execute</c></param>
    /// <param name="contentType"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Defaultsuccesstemplate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update the configuration for a workflow extension step.
    /// </remarks>
    public Task<Defaultsuccesstemplate> WorkflowsUpdateStep(string workflowStepEditId,
        string? inputs,
        string? outputs,
        string? stepName,
        string? stepImageUrl,
        string token,
        ContentType contentType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/workflows.updateStep"),
            [],
            [new Param("workflow_step_edit_id", workflowStepEditId),
                new Param("inputs", inputs),
                new Param("outputs", outputs),
                new Param("step_name", stepName),
                new Param("step_image_url", stepImageUrl)],
            [new HeaderParam("token", token), new HeaderParam("Content-Type", contentType)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Defaultsuccesstemplate>(),
            RawErrorResponse.Instance,
            [_auth.SlackAuth],
            requestOptions,
            ct);
}
