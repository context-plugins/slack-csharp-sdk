<!-- Generated file — do not edit; regenerated with the SDK. -->

# Apps — operations

Accessor: `client.Apps` · Source: `src/SlackWebApi/Api/Apps.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AppsEventAuthorizationsList

- **Auth**: `options.SlackAuth`
- **Signature**: `AppsEventAuthorizationsList(AppsEventAuthorizationsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `EventContext`, `Token`, `ContentType`
- **Query params (wire ← C#)**: `event_context` ← `EventContext`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AppsEventAuthorizationsListRequest` | `src/SlackWebApi/Requests/AppsEventAuthorizations/AppsEventAuthorizationsListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

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

### AppsPermissionsResourcesList

- **Auth**: `options.SlackAuth`
- **Signature**: `AppsPermissionsResourcesList(AppsPermissionsResourcesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `AppsPermissionsResourcesListsuccessschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AppsPermissionsResourcesListRequest` | `src/SlackWebApi/Requests/AppsPermissionsResources/AppsPermissionsResourcesListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `AppsPermissionsResourcesListsuccessschema` | `src/SlackWebApi/Models/AppsPermissionsResourcesListsuccessschema.cs` |

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

### AppsPermissionsUsersList

- **Auth**: `options.SlackAuth`
- **Signature**: `AppsPermissionsUsersList(AppsPermissionsUsersListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AppsPermissionsUsersListRequest` | `src/SlackWebApi/Requests/AppsPermissionsUsers/AppsPermissionsUsersListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AppsPermissionsUsersRequest

- **Auth**: `options.SlackAuth`
- **Signature**: `AppsPermissionsUsersRequest(AppsPermissionsUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `Scopes`, `TriggerId`, `User`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `scopes` ← `Scopes`, `trigger_id` ← `TriggerId`, `user` ← `User`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AppsPermissionsUsersRequest` | `src/SlackWebApi/Requests/AppsPermissionsUsers/AppsPermissionsUsersRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AppsUninstall

- **Auth**: `options.SlackAuth`
- **Signature**: `AppsUninstall(AppsUninstallRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `client_id` ← `ClientId`, `client_secret` ← `ClientSecret`
- **Returns**: `AppsUninstallschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AppsUninstallRequest` | `src/SlackWebApi/Requests/Apps/AppsUninstallRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `AppsUninstallschema` | `src/SlackWebApi/Models/AppsUninstallschema.cs` |

