<!-- Generated file — do not edit; regenerated with the SDK. -->

# AppsPermissionsResources — operations

Accessor: `client.AppsPermissionsResources` · Source: `Api/AppsPermissionsResources.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AppsPermissionsResourcesList

- **Signature**: `AppsPermissionsResourcesList(string token, string? cursor, int? limit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `AppsPermissionsResourcesListsuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AppsPermissionsResourcesListsuccessschema` | `Models/AppsPermissionsResourcesListsuccessschema.cs` |

