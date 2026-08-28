<!-- Generated file — do not edit; regenerated with the SDK. -->

# Workflows — operations

Accessor: `client.Workflows` · Source: `Api/Workflows.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### WorkflowsStepCompleted

- **Signature**: `WorkflowsStepCompleted(string workflowStepExecuteId, string? outputs, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `outputs` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `workflow_step_execute_id` ← `workflowStepExecuteId`, `outputs` ← `outputs`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### WorkflowsStepFailed

- **Signature**: `WorkflowsStepFailed(string workflowStepExecuteId, string error, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `workflow_step_execute_id` ← `workflowStepExecuteId`, `error` ← `error`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### WorkflowsUpdateStep

- **Signature**: `WorkflowsUpdateStep(string workflowStepEditId, string? inputs, string? outputs, string? stepName, string? stepImageUrl, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`inputs` … `stepImageUrl`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `workflow_step_edit_id` ← `workflowStepEditId`, `inputs` ← `inputs`, `outputs` ← `outputs`, `step_name` ← `stepName`, `step_image_url` ← `stepImageUrl`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

