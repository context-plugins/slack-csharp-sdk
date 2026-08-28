<!-- Generated file — do not edit; regenerated with the SDK. -->

# AppsPermissions — operations

Accessor: `client.AppsPermissions` · Source: `Api/AppsPermissions.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AppsPermissionsInfo

- **Signature**: `AppsPermissionsInfo(string? token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`
- **Returns**: `AppsPermissionsInfoschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AppsPermissionsInfoschema` | `Models/AppsPermissionsInfoschema.cs` |

### AppsPermissionsRequest

- **Signature**: `AppsPermissionsRequest(string token, string scopes, string triggerId, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `token` ← `token`, `scopes` ← `scopes`, `trigger_id` ← `triggerId`
- **Returns**: `AppsPermissionsRequestschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AppsPermissionsRequestschema` | `Models/AppsPermissionsRequestschema.cs` |

