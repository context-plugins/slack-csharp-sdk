using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Workflows;

/// <summary>
/// The inputs of the WorkflowsStepCompleted operation.
/// </summary>
public sealed record WorkflowsStepCompletedRequest
{
    /// <summary>
    /// Context identifier that maps to the correct workflow step execution.
    /// </summary>
    public required string WorkflowStepExecuteId { get; init; }

    /// <summary>
    /// Key-value object of outputs from your step. Keys of this object reflect the configured <c>key</c> properties of your <see href="/reference/workflows/workflow_step#output"><c>outputs</c></see> array from your <c>workflow_step</c> object.
    /// </summary>
    public string? Outputs { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>workflow.steps:execute</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }
}
