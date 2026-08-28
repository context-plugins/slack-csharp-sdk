<!-- Generated file — do not edit; regenerated with the SDK. -->

# Dialog — operations

Accessor: `client.Dialog` · Source: `Api/Dialog.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DialogOpen

- **Signature**: `DialogOpen(string dialog, string triggerId, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `dialog` ← `dialog`, `trigger_id` ← `triggerId`
- **Returns**: `DialogOpenschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `DialogOpenschema` | `Models/DialogOpenschema.cs` |

