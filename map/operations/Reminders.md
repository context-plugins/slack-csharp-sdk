<!-- Generated file — do not edit; regenerated with the SDK. -->

# Reminders — operations

Accessor: `client.Reminders` · Source: `Api/Reminders.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### RemindersAdd

- **Auth**: `options.SlackAuth`
- **Signature**: `RemindersAdd(string token, ContentType contentType, string text, string time, string? user, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `user` — nullable, no default → **must pass explicitly**
- **Returns**: `RemindersAddschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `RemindersAddschema` | `Models/RemindersAddschema.cs` |

### RemindersComplete

- **Auth**: `options.SlackAuth`
- **Signature**: `RemindersComplete(ContentType contentType, string? token, string? reminder, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `reminder` — nullable, no default → **must pass explicitly**
- **Returns**: `RemindersCompleteschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `RemindersCompleteschema` | `Models/RemindersCompleteschema.cs` |

### RemindersDelete

- **Auth**: `options.SlackAuth`
- **Signature**: `RemindersDelete(ContentType contentType, string? token, string? reminder, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `reminder` — nullable, no default → **must pass explicitly**
- **Returns**: `RemindersDeleteschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `RemindersDeleteschema` | `Models/RemindersDeleteschema.cs` |

### RemindersInfo

- **Auth**: `options.SlackAuth`
- **Signature**: `RemindersInfo(string? token, string? reminder, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
  - `reminder` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`, `reminder` ← `reminder`
- **Returns**: `RemindersInfoschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `RemindersInfoschema` | `Models/RemindersInfoschema.cs` |

### RemindersList

- **Auth**: `options.SlackAuth`
- **Signature**: `RemindersList(string? token, ContentType contentType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `token` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `token` ← `token`
- **Returns**: `RemindersListschema`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentType` | `Models/Enums/ContentType.cs` |
| `RemindersListschema` | `Models/RemindersListschema.cs` |

