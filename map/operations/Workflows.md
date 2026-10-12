<!-- Generated file — do not edit; regenerated with the SDK. -->

# Workflows — operations

Accessor: `client.Workflows` · Source: `src/SlackWebApi/Api/Workflows.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### WorkflowsStepCompleted

- **Auth**: `options.SlackAuth`
- **Signature**: `WorkflowsStepCompleted(WorkflowsStepCompletedRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `WorkflowStepExecuteId`, `Token`, `ContentType`
- **Query params (wire ← C#)**: `workflow_step_execute_id` ← `WorkflowStepExecuteId`, `outputs` ← `Outputs`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WorkflowsStepCompletedRequest` | `src/SlackWebApi/Requests/Workflows/WorkflowsStepCompletedRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### WorkflowsStepFailed

- **Auth**: `options.SlackAuth`
- **Signature**: `WorkflowsStepFailed(WorkflowsStepFailedRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `WorkflowStepExecuteId`, `Error`, `Token`, `ContentType`
- **Query params (wire ← C#)**: `workflow_step_execute_id` ← `WorkflowStepExecuteId`, `error` ← `Error`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WorkflowsStepFailedRequest` | `src/SlackWebApi/Requests/Workflows/WorkflowsStepFailedRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### WorkflowsUpdateStep

- **Auth**: `options.SlackAuth`
- **Signature**: `WorkflowsUpdateStep(WorkflowsUpdateStepRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `WorkflowStepEditId`, `Token`, `ContentType`
- **Query params (wire ← C#)**: `workflow_step_edit_id` ← `WorkflowStepEditId`, `inputs` ← `Inputs`, `outputs` ← `Outputs`, `step_name` ← `StepName`, `step_image_url` ← `StepImageUrl`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WorkflowsUpdateStepRequest` | `src/SlackWebApi/Requests/Workflows/WorkflowsUpdateStepRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

