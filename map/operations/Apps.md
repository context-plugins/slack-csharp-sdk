<!-- Generated file — do not edit; regenerated with the SDK. -->

# Apps — operations

Accessor: `client.Apps` · Source: `Api/Apps.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AppsEventAuthorizationsList

- **Signature**: `AppsEventAuthorizationsList(string eventContext, string? cursor, int? limit, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `event_context` ← `eventContext`, `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

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

### AppsPermissionsScopesList

- **Signature**: `AppsPermissionsScopesList(string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `token` ← `token`
- **Returns**: `ApiPermissionsScopesListsuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ApiPermissionsScopesListsuccessschema` | `Models/ApiPermissionsScopesListsuccessschema.cs` |

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

### AppsUninstall

- **Signature**: `AppsUninstall(string? token, string? clientId, string? clientSecret, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `clientId` — nullable, no default → **must pass explicitly**
  - `clientSecret` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `client_id` ← `clientId`, `client_secret` ← `clientSecret`
- **Returns**: `AppsUninstallschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `AppsUninstallschema` | `Models/AppsUninstallschema.cs` |

