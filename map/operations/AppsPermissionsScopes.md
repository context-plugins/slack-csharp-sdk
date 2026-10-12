<!-- Generated file — do not edit; regenerated with the SDK. -->

# AppsPermissionsScopes — operations

Accessor: `client.AppsPermissionsScopes` · Source: `src/SlackWebApi/Api/AppsPermissionsScopes.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AppsPermissionsScopesList

- **Auth**: `options.SlackAuth`
- **Signature**: `AppsPermissionsScopesList(AppsPermissionsScopesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`
- **Returns**: `ApiPermissionsScopesListsuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AppsPermissionsScopesListRequest` | `src/SlackWebApi/Requests/AppsPermissionsScopes/AppsPermissionsScopesListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `ApiPermissionsScopesListsuccessschema` | `src/SlackWebApi/Models/ApiPermissionsScopesListsuccessschema.cs` |

