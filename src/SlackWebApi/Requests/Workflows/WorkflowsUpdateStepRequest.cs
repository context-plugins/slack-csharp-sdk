using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Workflows;

/// <summary>
/// The inputs of the WorkflowsUpdateStep operation.
/// </summary>
public sealed record WorkflowsUpdateStepRequest
{
    /// <summary>
    /// A context identifier provided with <c>view_submission</c> payloads used to call back to <c>workflows.updateStep</c>.
    /// </summary>
    public required string WorkflowStepEditId { get; init; }

    /// <summary>
    /// A JSON key-value map of inputs required from a user during configuration. This is the data your app expects to receive when the workflow step starts. <b>Please note</b>: the embedded variable format is set and replaced by the workflow system. You cannot create custom variables that will be replaced at runtime. <see href="/workflows/steps#variables">Read more about variables in workflow steps here</see>.
    /// </summary>
    public string? Inputs { get; init; }

    /// <summary>
    /// An JSON array of output objects used during step execution. This is the data your app agrees to provide when your workflow step was executed.
    /// </summary>
    public string? Outputs { get; init; }

    /// <summary>
    /// An optional field that can be used to override the step name that is shown in the Workflow Builder.
    /// </summary>
    public string? StepName { get; init; }

    /// <summary>
    /// An optional field that can be used to override app image that is shown in the Workflow Builder.
    /// </summary>
    public string? StepImageUrl { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>workflow.steps:execute</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }
}
