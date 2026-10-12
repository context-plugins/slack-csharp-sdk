using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Workflows;

/// <summary>
/// The inputs of the WorkflowsStepFailed operation.
/// </summary>
public sealed record WorkflowsStepFailedRequest
{
    /// <summary>
    /// Context identifier that maps to the correct workflow step execution.
    /// </summary>
    public required string WorkflowStepExecuteId { get; init; }

    /// <summary>
    /// A JSON-based object with a <c>message</c> property that should contain a human readable error message.
    /// </summary>
    public required string Error { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>workflow.steps:execute</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }
}
