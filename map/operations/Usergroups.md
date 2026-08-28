<!-- Generated file — do not edit; regenerated with the SDK. -->

# Usergroups — operations

Accessor: `client.Usergroups` · Source: `Api/Usergroups.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### UsergroupsCreate

- **Signature**: `UsergroupsCreate(string token, ContentType contentType, string name, string? channels, string? description, string? handle, bool? includeCount, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`channels` … `includeCount`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `UsergroupsCreateschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `UsergroupsCreateschema` | `Models/UsergroupsCreateschema.cs` |

### UsergroupsDisable

- **Signature**: `UsergroupsDisable(string token, ContentType contentType, string usergroup, bool? includeCount, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `includeCount` — nullable, no default → **must pass explicitly**
- **Returns**: `UsergroupsDisableschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `UsergroupsDisableschema` | `Models/UsergroupsDisableschema.cs` |

### UsergroupsEnable

- **Signature**: `UsergroupsEnable(string token, ContentType contentType, string usergroup, bool? includeCount, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `includeCount` — nullable, no default → **must pass explicitly**
- **Returns**: `UsergroupsEnableschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `UsergroupsEnableschema` | `Models/UsergroupsEnableschema.cs` |

### UsergroupsList

- **Signature**: `UsergroupsList(string token, bool? includeUsers, bool? includeCount, bool? includeDisabled, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `includeUsers` — nullable, no default → **must pass explicitly**
  - `includeCount` — nullable, no default → **must pass explicitly**
  - `includeDisabled` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `include_users` ← `includeUsers`, `include_count` ← `includeCount`, `include_disabled` ← `includeDisabled`
- **Returns**: `UsergroupsListschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `UsergroupsListschema` | `Models/UsergroupsListschema.cs` |

### UsergroupsUpdate

- **Signature**: `UsergroupsUpdate(string token, ContentType contentType, string usergroup, string? handle, string? description, string? channels, bool? includeCount, string? name, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`handle` … `name`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `UsergroupsUpdateschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `UsergroupsUpdateschema` | `Models/UsergroupsUpdateschema.cs` |

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

