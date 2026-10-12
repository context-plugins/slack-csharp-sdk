<!-- Generated file — do not edit; regenerated with the SDK. -->

# Usergroups — operations

Accessor: `client.Usergroups` · Source: `src/SlackWebApi/Api/Usergroups.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### UsergroupsCreate

- **Auth**: `options.SlackAuth`
- **Signature**: `UsergroupsCreate(UsergroupsCreateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `Name`
- **Returns**: `UsergroupsCreateschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsergroupsCreateRequest` | `src/SlackWebApi/Requests/Usergroups/UsergroupsCreateRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `UsergroupsCreateschema` | `src/SlackWebApi/Models/UsergroupsCreateschema.cs` |

### UsergroupsDisable

- **Auth**: `options.SlackAuth`
- **Signature**: `UsergroupsDisable(UsergroupsDisableRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `Usergroup`
- **Returns**: `UsergroupsDisableschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsergroupsDisableRequest` | `src/SlackWebApi/Requests/Usergroups/UsergroupsDisableRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `UsergroupsDisableschema` | `src/SlackWebApi/Models/UsergroupsDisableschema.cs` |

### UsergroupsEnable

- **Auth**: `options.SlackAuth`
- **Signature**: `UsergroupsEnable(UsergroupsEnableRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `Usergroup`
- **Returns**: `UsergroupsEnableschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsergroupsEnableRequest` | `src/SlackWebApi/Requests/Usergroups/UsergroupsEnableRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `UsergroupsEnableschema` | `src/SlackWebApi/Models/UsergroupsEnableschema.cs` |

### UsergroupsList

- **Auth**: `options.SlackAuth`
- **Signature**: `UsergroupsList(UsergroupsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `include_users` ← `IncludeUsers`, `include_count` ← `IncludeCount`, `include_disabled` ← `IncludeDisabled`
- **Returns**: `UsergroupsListschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsergroupsListRequest` | `src/SlackWebApi/Requests/Usergroups/UsergroupsListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `UsergroupsListschema` | `src/SlackWebApi/Models/UsergroupsListschema.cs` |

### UsergroupsUpdate

- **Auth**: `options.SlackAuth`
- **Signature**: `UsergroupsUpdate(UsergroupsUpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `Usergroup`
- **Returns**: `UsergroupsUpdateschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsergroupsUpdateRequest` | `src/SlackWebApi/Requests/Usergroups/UsergroupsUpdateRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `UsergroupsUpdateschema` | `src/SlackWebApi/Models/UsergroupsUpdateschema.cs` |

### UsergroupsUsersList

- **Auth**: `options.SlackAuth`
- **Signature**: `UsergroupsUsersList(UsergroupsUsersListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `Usergroup`, `ContentType`
- **Query params (wire ← C#)**: `token` ← `Token`, `usergroup` ← `Usergroup`, `include_disabled` ← `IncludeDisabled`
- **Returns**: `UsergroupsUsersListschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsergroupsUsersListRequest` | `src/SlackWebApi/Requests/UsergroupsUsers/UsergroupsUsersListRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `UsergroupsUsersListschema` | `src/SlackWebApi/Models/UsergroupsUsersListschema.cs` |

### UsergroupsUsersUpdate

- **Auth**: `options.SlackAuth`
- **Signature**: `UsergroupsUsersUpdate(UsergroupsUsersUpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Token`, `ContentType`, `Usergroup`, `Users`
- **Returns**: `UsergroupsUsersUpdateschema`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsergroupsUsersUpdateRequest` | `src/SlackWebApi/Requests/UsergroupsUsers/UsergroupsUsersUpdateRequest.cs` |
| `ContentType` | `src/SlackWebApi/Models/Enums/ContentType.cs` |
| `UsergroupsUsersUpdateschema` | `src/SlackWebApi/Models/UsergroupsUsersUpdateschema.cs` |

