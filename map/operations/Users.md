<!-- Generated file — do not edit; regenerated with the SDK. -->

# Users — operations

Accessor: `client.Users` · Source: `Api/Users.cs` · 12 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### UsersConversations

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersConversations(string? token, string? user, string? types, bool? excludeArchived, int? limit, string? cursor, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`token` … `cursor`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `token` ← `token`, `user` ← `user`, `types` ← `types`, `exclude_archived` ← `excludeArchived`, `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `UsersConversationssuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `UsersConversationssuccessschema` | `Models/UsersConversationssuccessschema.cs` |

### UsersDeletePhoto

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersDeletePhoto(ContentType contentType, string token, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UsersDeletePhotoschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `UsersDeletePhotoschema` | `Models/UsersDeletePhotoschema.cs` |

### UsersGetPresence

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersGetPresence(string token, string? user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `user` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `user` ← `user`
- **Returns**: `ApImethodusersGetPresence`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `ApImethodusersGetPresence` | `Models/ApImethodusersGetPresence.cs` |

### UsersIdentity

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersIdentity(string? token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`
- **Returns**: `object`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |

### UsersInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersInfo(string token, bool? includeLocale, string? user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `includeLocale` — nullable, no default → **must pass explicitly**
  - `user` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `include_locale` ← `includeLocale`, `user` ← `user`
- **Returns**: `UsersInfosuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `UsersInfosuccessschema` | `Models/UsersInfosuccessschema.cs` |

### UsersList

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersList(string? token, int? limit, string? cursor, bool? includeLocale, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`token` … `includeLocale`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `token` ← `token`, `limit` ← `limit`, `cursor` ← `cursor`, `include_locale` ← `includeLocale`
- **Returns**: `UsersListschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `UsersListschema` | `Models/UsersListschema.cs` |

### UsersLookupByEmail

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersLookupByEmail(string token, string email, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `token` ← `token`, `email` ← `email`
- **Returns**: `UsersLookupByEmailsuccessschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `UsersLookupByEmailsuccessschema` | `Models/UsersLookupByEmailsuccessschema.cs` |

### UsersProfileGet

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersProfileGet(string token, bool? includeLabels, string? user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `includeLabels` — nullable, no default → **must pass explicitly**
  - `user` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `include_labels` ← `includeLabels`, `user` ← `user`
- **Returns**: `UsersProfileGetschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `UsersProfileGetschema` | `Models/UsersProfileGetschema.cs` |

### UsersProfileSet

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersProfileSet(string token, ContentType contentType, string? name, string? profile, string? user, string? value, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`name` … `value`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `UsersProfileSetschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `UsersProfileSetschema` | `Models/UsersProfileSetschema.cs` |

### UsersSetActive

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersSetActive(string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UsersSetActiveschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `UsersSetActiveschema` | `Models/UsersSetActiveschema.cs` |

### UsersSetPhoto

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersSetPhoto(ContentType contentType, string token, string? cropW, string? cropX, string? cropY, string? image, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`cropW` … `image`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `UsersSetPhotoschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `UsersSetPhotoschema` | `Models/UsersSetPhotoschema.cs` |

### UsersSetPresence

- **Auth**: `options.SlackAuth`
- **Signature**: `UsersSetPresence(string token, ContentType contentType, string presence, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UsersSetPresenceschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `UsersSetPresenceschema` | `Models/UsersSetPresenceschema.cs` |

