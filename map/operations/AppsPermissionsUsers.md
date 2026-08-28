<!-- Generated file — do not edit; regenerated with the SDK. -->

# AppsPermissionsUsers — operations

Accessor: `client.AppsPermissionsUsers` · Source: `Api/AppsPermissionsUsers.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AppsPermissionsUsersList

- **Signature**: `AppsPermissionsUsersList(string token, string? cursor, int? limit, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### AppsPermissionsUsersRequest

- **Signature**: `AppsPermissionsUsersRequest(string token, string scopes, string triggerId, string user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `token` ← `token`, `scopes` ← `scopes`, `trigger_id` ← `triggerId`, `user` ← `user`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

