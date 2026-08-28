<!-- Generated file — do not edit; regenerated with the SDK. -->

# UsergroupsUsers — operations

Accessor: `client.UsergroupsUsers` · Source: `Api/UsergroupsUsers.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### UsergroupsUsersList

- **Signature**: `UsergroupsUsersList(string token, string usergroup, bool? includeDisabled, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `includeDisabled` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `usergroup` ← `usergroup`, `include_disabled` ← `includeDisabled`
- **Returns**: `UsergroupsUsersListschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `UsergroupsUsersListschema` | `Models/UsergroupsUsersListschema.cs` |

### UsergroupsUsersUpdate

- **Signature**: `UsergroupsUsersUpdate(string token, ContentType contentType, string usergroup, string users, bool? includeCount, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `includeCount` — nullable, no default → **must pass explicitly**
- **Returns**: `UsergroupsUsersUpdateschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `UsergroupsUsersUpdateschema` | `Models/UsergroupsUsersUpdateschema.cs` |

