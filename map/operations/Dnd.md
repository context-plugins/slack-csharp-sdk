<!-- Generated file — do not edit; regenerated with the SDK. -->

# Dnd — operations

Accessor: `client.Dnd` · Source: `Api/Dnd.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DndEndDnd

- **Signature**: `DndEndDnd(string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DndEndDndschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `DndEndDndschema` | `Models/DndEndDndschema.cs` |

### DndEndSnooze

- **Signature**: `DndEndSnooze(string token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DndEndSnoozeschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `DndEndSnoozeschema` | `Models/DndEndSnoozeschema.cs` |

### DndInfo

- **Signature**: `DndInfo(string? token, string? user, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `user` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `user` ← `user`
- **Returns**: `DndInfoschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `DndInfoschema` | `Models/DndInfoschema.cs` |

### DndSetSnooze

- **Signature**: `DndSetSnooze(ContentType contentType, string token, string numMinutes, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DndSetSnoozeschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `DndSetSnoozeschema` | `Models/DndSetSnoozeschema.cs` |

### DndTeamInfo

- **Signature**: `DndTeamInfo(string? token, string? users, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `users` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `users` ← `users`
- **Returns**: `Defaultsuccesstemplate`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `Defaultsuccesstemplate` | `Models/Defaultsuccesstemplate.cs` |

