<!-- Generated file — do not edit; regenerated with the SDK. -->

# AppsPermissions — operations

Accessor: `client.AppsPermissions` · Source: `src/SlackWebApi/Api/AppsPermissions.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AppsPermissionsInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `AppsPermissionsInfo(AppsPermissionsInfoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`
- **Returns**: `AppsPermissionsInfoschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AppsPermissionsInfoRequest` | `src/SlackWebApi/Requests/AppsPermissions/AppsPermissionsInfoRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `AppsPermissionsInfoschema` | `src/SlackWebApi/Models/AppsPermissionsInfoschema.cs` |

### AppsPermissionsRequest

- **Auth**: `options.SlackAuth`
- **Signature**: `AppsPermissionsRequest(AppsPermissionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `Scopes`, `TriggerId`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `scopes` ← `Scopes`, `trigger_id` ← `TriggerId`
- **Returns**: `AppsPermissionsRequestschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AppsPermissionsRequest` | `src/SlackWebApi/Requests/AppsPermissions/AppsPermissionsRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `AppsPermissionsRequestschema` | `src/SlackWebApi/Models/AppsPermissionsRequestschema.cs` |

