<!-- Generated file — do not edit; regenerated with the SDK. -->

# UsergroupsUsers — operations

Accessor: `client.UsergroupsUsers` · Source: `src/SlackWebApi/Api/UsergroupsUsers.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

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

