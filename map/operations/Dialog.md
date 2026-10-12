<!-- Generated file — do not edit; regenerated with the SDK. -->

# Dialog — operations

Accessor: `client.Dialog` · Source: `src/SlackWebApi/Api/Dialog.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DialogOpen

- **Auth**: `options.SlackAuth`
- **Signature**: `DialogOpen(DialogOpenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Dialog`, `TriggerId`, `Token`, `ContentType`
- **Query params (wire ← C#)**: `dialog` ← `Dialog`, `trigger_id` ← `TriggerId`
- **Returns**: `DialogOpenschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DialogOpenRequest` | `src/SlackWebApi/Requests/Dialog/DialogOpenRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `DialogOpenschema` | `src/SlackWebApi/Models/DialogOpenschema.cs` |

