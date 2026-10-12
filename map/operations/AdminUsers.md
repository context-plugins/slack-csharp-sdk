<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdminUsers — operations

Accessor: `client.AdminUsers` · Source: `src/SlackWebApi/Api/AdminUsers.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AdminUsersAssign

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersAssign(AdminUsersAssignRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamId`, `UserId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersAssignRequest` | `src/SlackWebApi/Requests/AdminUsers/AdminUsersAssignRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsersInvite

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersInvite(AdminUsersInviteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamId`, `Email`, `ChannelIds`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersInviteRequest` | `src/SlackWebApi/Requests/AdminUsers/AdminUsersInviteRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsersList

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersList(AdminUsersListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TeamId`, `Token`, `ContentType`
- **Query params (wire ← C#)**: `team_id` ← `TeamId`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersListRequest` | `src/SlackWebApi/Requests/AdminUsers/AdminUsersListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsersRemove

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersRemove(AdminUsersRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamId`, `UserId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersRemoveRequest` | `src/SlackWebApi/Requests/AdminUsers/AdminUsersRemoveRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsersSetAdmin

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersSetAdmin(AdminUsersSetAdminRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamId`, `UserId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersSetAdminRequest` | `src/SlackWebApi/Requests/AdminUsers/AdminUsersSetAdminRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsersSetExpiration

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersSetExpiration(AdminUsersSetExpirationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamId`, `UserId`, `ExpirationTs`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersSetExpirationRequest` | `src/SlackWebApi/Requests/AdminUsers/AdminUsersSetExpirationRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsersSetOwner

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersSetOwner(AdminUsersSetOwnerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamId`, `UserId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersSetOwnerRequest` | `src/SlackWebApi/Requests/AdminUsers/AdminUsersSetOwnerRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

### AdminUsersSetRegular

- **Auth**: `options.SlackAuth`
- **Signature**: `AdminUsersSetRegular(AdminUsersSetRegularRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `TeamId`, `UserId`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminUsersSetRegularRequest` | `src/SlackWebApi/Requests/AdminUsers/AdminUsersSetRegularRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `src/SlackWebApi/Models/Defaultsuccesstemplate.cs` |

