<!-- Generated file — do not edit; regenerated with the SDK. -->

# AppsPermissionsUsers — operations

Accessor: `client.AppsPermissionsUsers` · Source: `src/SlackWebApi/Api/AppsPermissionsUsers.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

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

