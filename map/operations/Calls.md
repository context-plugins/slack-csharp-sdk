<!-- Generated file — do not edit; regenerated with the SDK. -->

# Calls — operations

Accessor: `client.Calls` · Source: `Api/Calls.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CallsAdd

- **Auth**: `options.SlackAuth`
- **Signature**: `CallsAdd(string token, ContentType contentType, string externalUniqueId, string joinUrl, string? externalDisplayId, string? desktopAppJoinUrl, int? dateStart, string? title, string? createdBy, string? users, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`externalDisplayId` … `users`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### CallsEnd

- **Auth**: `options.SlackAuth`
- **Signature**: `CallsEnd(string token, ContentType contentType, string id, int? duration, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `duration` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### CallsInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `CallsInfo(string id, string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `id` ← `id`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### CallsParticipantsAdd

- **Auth**: `options.SlackAuth`
- **Signature**: `CallsParticipantsAdd(string token, ContentType contentType, string id, string users, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### CallsParticipantsRemove

- **Auth**: `options.SlackAuth`
- **Signature**: `CallsParticipantsRemove(string token, ContentType contentType, string id, string users, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

### CallsUpdate

- **Auth**: `options.SlackAuth`
- **Signature**: `CallsUpdate(string token, ContentType contentType, string id, string? title, string? joinUrl, string? desktopAppJoinUrl, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `title` — nullable, no default → **must pass explicitly**
  - `joinUrl` — nullable, no default → **must pass explicitly**
  - `desktopAppJoinUrl` — nullable, no default → **must pass explicitly**
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

