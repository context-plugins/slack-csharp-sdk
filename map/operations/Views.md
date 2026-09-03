<!-- Generated file — do not edit; regenerated with the SDK. -->

# Views — operations

Accessor: `client.Views` · Source: `Api/Views.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ViewsOpen

- **Auth**: `options.SlackAuth`
- **Signature**: `ViewsOpen(string triggerId, string view, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `trigger_id` ← `triggerId`, `view` ← `view`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### ViewsPublish

- **Auth**: `options.SlackAuth`
- **Signature**: `ViewsPublish(string userId, string view, string? hash, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `hash` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `user_id` ← `userId`, `view` ← `view`, `hash` ← `hash`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### ViewsPush

- **Auth**: `options.SlackAuth`
- **Signature**: `ViewsPush(string triggerId, string view, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `trigger_id` ← `triggerId`, `view` ← `view`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### ViewsUpdate

- **Auth**: `options.SlackAuth`
- **Signature**: `ViewsUpdate(string? viewId, string? externalId, string? view, string? hash, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`viewId` … `hash`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `view_id` ← `viewId`, `external_id` ← `externalId`, `view` ← `view`, `hash` ← `hash`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

